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
    public partial class TopGoods : Form
    {
        PgSqlConnection sc = new PgSqlConnection(@"User Id=postgres;Host=localhost;Database=Firm;Password=12345;Persist Security Info=True;Initial Schema=public");
        PgSqlCommand cmd = new PgSqlCommand(); 
        public TopGoods()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Goods gd = new Goods();
            gd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc.Open();
            if (Convert.ToDateTime(dateTimePicker1.Text) < Convert.ToDateTime(dateTimePicker2.Text))
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                string query = "select distinct name,priority from sales join goods on sales.good_id = goods.id where sales.create_date > '"+Convert.ToDateTime(dateTimePicker1.Text)+"' and sales.create_date < '"+Convert.ToDateTime(dateTimePicker2.Text)+"' order by goods.priority desc fetch first 5 rows only";
                PgSqlCommand command = new PgSqlCommand(query, sc);

                PgSqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[2]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    //data[data.Count - 1][2] = reader[2].ToString();
                    //data[data.Count - 1][2] = reader[2].ToString();
                }

                reader.Close();

                sc.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
            else
            {
                MessageBox.Show("Неправильный диапазон.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
