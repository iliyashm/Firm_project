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
    public partial class Warehouse2 : Form
    {
        PgSqlConnection sc = new PgSqlConnection(@"User Id=postgres;Host=localhost;Database=Firm;Password=12345;Persist Security Info=True;Initial Schema=public");
        PgSqlCommand cmd = new PgSqlCommand();
        public Warehouse2()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void warehouse2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.warehouse2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.firmDataSet);

        }

        private void Warehouse2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmDataSet.warehouse2' table. You can move, or remove it, as needed.
            //this.warehouse2TableAdapter.Fill(this.firmDataSet.warehouse2);
            sc.Open();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string query = "select name,warehouse2.id,warehouse2.good_id,warehouse2.good_count from warehouse2 join goods on goods.id = warehouse2.good_id;";

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
            if (dataGridView1.CurrentRow.Selected == true && !dataGridView1.CurrentRow.IsNewRow)
            {
                sc.Open();


                PgSqlCommand Updatewh2 = new PgSqlCommand("update warehouse2 set good_count = good_count - 5 where warehouse2.id = '" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value) + "'", sc);
                try
                {

                    Updatewh2.ExecuteNonQuery();
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
    }
}
