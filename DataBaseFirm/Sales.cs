using System;
using Devart.Data.PostgreSql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseFirm
{
    public partial class Sales : Form
    {
        PgSqlConnection sc = new PgSqlConnection(@"User Id=postgres;Host=localhost;Database=Firm;Password=12345;Persist Security Info=True;Initial Schema=public");
        PgSqlCommand cmd = new PgSqlCommand(); 
        public Sales()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void salesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.firmDataSet);

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmDataSet.sales' table. You can move, or remove it, as needed.
            //this.salesTableAdapter.Fill(this.firmDataSet.sales);
            sc.Open();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string query = "select name,sales.id,sales.good_id,sales.good_count,sales.create_date from sales join goods on goods.id = sales.good_id;";

            PgSqlCommand command = new PgSqlCommand(query, sc);

            PgSqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            sc.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User us = new User();
            us.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc.Open();
            string result = null;
            //+ Convert.ToDateTime(dateTimePicker1.Text) +
            cmd.CommandText = "select sum(good_count) as numg from sales where create_date = '"+ Convert.ToDateTime(dateTimePicker1.Text) +"'";
            using (PgSqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    textBox1.Clear();
                    result = reader["numg"].ToString();
                    if (result == "")
                    {
                        textBox1.Paste("0");
                    }
                    else
                    {
                        textBox1.Paste(reader["numg"].ToString());
                    }
                }
            }
            sc.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Priority pr = new Priority();
            pr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AllGoods alg = new AllGoods();
            alg.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sc.Open();
            string result = null;
            //+ Convert.ToDateTime(dateTimePicker1.Text) +
            cmd.CommandText = "select SUM(warehouse1.good_count) - SUM(sales.good_count) as Ready_for_sale from sales join goods on sales.good_id = goods.id join warehouse1 on warehouse1.good_id = goods.id where sales.create_date = '"+ Convert.ToDateTime(dateTimePicker1.Text) +"'";
            using (PgSqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    textBox2.Clear();
                    result = reader["Ready_for_sale"].ToString();
                    if (result == "")
                    {
                        textBox2.Paste("0");
                    }
                    else
                    {
                        textBox2.Paste(reader["Ready_for_sale"].ToString());
                    }
                }
            }
            sc.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InsertSale isl = new InsertSale();
            isl.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                sc.Open();


                PgSqlCommand Deletecertgood = new PgSqlCommand("do $$"+
	"declare "+ 
		"goodname int; "+
        "good_to_remove int = " + Convert.ToInt32(textBox3.Text) + "; " +
"begin "+
    "select id into goodname from goods where name = '" + textBox4.Text + "'; " +
	"update sales set good_id = goodname where good_id = good_to_remove; "+
	"delete from sales where good_id = goodname; "+
"commit; "+
"end$$", sc);
                try
                {

                    Deletecertgood.ExecuteNonQuery();
                    //Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //sc.Close();
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Max_Stonk ms = new Max_Stonk();
            ms.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Max_priority mp = new Max_priority();
            mp.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Spros sp = new Spros();
            sp.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //this.salesTableAdapter.Fill(this.firmDataSet.sales);
            sc.Open();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string query = "select name,sales.id,sales.good_id,sales.good_count,sales.create_date from sales join goods on goods.id = sales.good_id;";

            PgSqlCommand command = new PgSqlCommand(query, sc);

            PgSqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            sc.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sc.Open();
            PgSqlCommand deletegood = new PgSqlCommand("delete from sales where create_date < '" + Convert.ToDateTime(dateTimePicker1.Text) + "';",sc);
            try
            {

                deletegood.ExecuteNonQuery();
                //Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //sc.Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                if (dataGridView1.CurrentRow.Selected == true && !dataGridView1.CurrentRow.IsNewRow)
                {
                    sc.Open();
                    PgSqlCommand updatesale = new PgSqlCommand("update sales set good_count = '" + Convert.ToInt32(textBox5.Text) + "' where id = '" + (dataGridView1.CurrentRow.Cells[1].Value).ToString() + "'", sc);
                    try
                    {

                        updatesale.ExecuteNonQuery();
                        //Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //sc.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали нужный товар", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MinStonk ms = new MinStonk();
            ms.Show();
        }
        }
        
 }

