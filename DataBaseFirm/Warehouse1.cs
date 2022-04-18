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
    public partial class Warehouse1 : Form
    {
        PgSqlConnection sc = new PgSqlConnection(@"User Id=postgres;Host=localhost;Database=Firm;Password=12345;Persist Security Info=True;Initial Schema=public");
        PgSqlCommand cmd = new PgSqlCommand();
        public Warehouse1()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void warehouse1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.warehouse1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.firmDataSet);

        }

        private void Warehouse1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmDataSet.warehouse1' table. You can move, or remove it, as needed.
            //this.warehouse1TableAdapter.FillBy(this.firmDataSet.warehouse1);
            sc.Open();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            
                string query = "select name,warehouse1.id,warehouse1.good_id,warehouse1.good_count from warehouse1 join goods on goods.id = warehouse1.good_id;";

                PgSqlCommand command = new PgSqlCommand(query, sc);

                PgSqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    //data[data.Count - 1][4] = reader[4].ToString();
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


            PgSqlCommand Deletemingood = new PgSqlCommand("do $$ " +
    "declare " +
     "minimum int; " +
"Begin " +

    "select priority into minimum from goods order by priority desc limit 1; " +
    "delete from warehouse1 using goods where goods.id = warehouse1.good_id and goods.priority = minimum; " +

//"rollback; " +
"end$$;",sc);
            try
            {

                Deletemingood.ExecuteNonQuery();
                //Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //sc.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sc.Open();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string query = "select name,warehouse1.id,warehouse1.good_id,warehouse1.good_count from warehouse1 join goods on goods.id = warehouse1.good_id;";

            PgSqlCommand command = new PgSqlCommand(query, sc);

            PgSqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                //data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            sc.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected == true && !dataGridView1.CurrentRow.IsNewRow)
            {
                sc.Open();


                PgSqlCommand Updategood = new PgSqlCommand("do $$ " +
        "declare " +
            "var int; " +
            "idofgood int; " +
    "begin " +
        "select id into idofgood from goods where id = '" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value) + "'; " +
        "select good_count - 5 into var from warehouse1 where good_id = idofgood; " +
        "if var < 0 then " +
            "update warehouse1 set good_count = '0' where good_id = idofgood; " +
            "update warehouse2 set good_count = good_count + var where good_id = idofgood; " +
        "else " +
            "update warehouse1 set good_count = good_count - 5 where good_id = idofgood; " +
        "end if; " +
    "commit; " +
    "end$$;", sc);
                try
                {

                    Updategood.ExecuteNonQuery();
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

        private void button5_Click(object sender, EventArgs e)
        {
            List ls = new List();
            ls.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Transporting tr = new Transporting();
            tr.Show();
        }
    }
}
