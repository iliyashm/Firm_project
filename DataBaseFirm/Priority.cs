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
    public partial class Priority : Form
    {
        PgSqlConnection sc = new PgSqlConnection(@"User Id=postgres;Host=localhost;Database=Firm;Password=12345;Persist Security Info=True;Initial Schema=public");
        PgSqlCommand cmd = new PgSqlCommand(); 
        public Priority()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sales sl = new Sales();
            sl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc.Open();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            if (textBox1.Text != "")
            {
                string query = "select name,sales.id,good_id,good_count,create_date from sales join goods on sales.good_id = goods.id where goods.priority < '" + textBox1.Text + "'";

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
            else
            {
                MessageBox.Show("Поле приоритета не должно быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
