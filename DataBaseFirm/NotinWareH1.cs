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
    public partial class NotinWareH1 : Form
    {
        PgSqlConnection sc = new PgSqlConnection(@"User Id=postgres;Host=localhost;Database=Firm;Password=12345;Persist Security Info=True;Initial Schema=public");
        PgSqlCommand cmd = new PgSqlCommand(); 
        public NotinWareH1()
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
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            
            string query = "select name from goods g where not exists(select good_id from warehouse1 w where w.good_id = g.id)";

            PgSqlCommand command = new PgSqlCommand(query, sc);

            PgSqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[1]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    //data[data.Count - 1][1] = reader[1].ToString();
                    //data[data.Count - 1][2] = reader[2].ToString();
                    //data[data.Count - 1][2] = reader[2].ToString();
                }

                reader.Close();

                sc.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
           
        }
    }
}
