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
    public partial class InsertWarehouses : Form
    {
        PgSqlConnection sc = new PgSqlConnection(@"User Id=postgres;Host=localhost;Database=Firm;Password=12345;Persist Security Info=True;Initial Schema=public");
        PgSqlCommand cmd = new PgSqlCommand(); 
        public InsertWarehouses()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                sc.Open();
                PgSqlCommand Insertsale = new PgSqlCommand("do $$ " +
	"declare "+
		"goodc int; "+
		"idofgood int; "+
"Begin "+

    "insert into goods (Name,Priority) values ('" + textBox1.Text + "','" + textBox2.Text + "'); " +
    "select id into idofgood from goods where Name = '" + textBox1.Text + "'; " +
    "insert into warehouse2 (Good_id,Good_count) values (idofgood,'" + Convert.ToInt32(textBox4.Text) + "'); " +
    "insert into warehouse1 (Good_id,Good_count) values (idofgood,'" + Convert.ToInt32(textBox3.Text) + "'); " +
	"select sum(good_count) into goodc from warehouse1; "+
	"if goodc < 300 then "+
		"commit;"+
	"else "+
		"rollback;"+
	"end if;"+
"end$$;", sc);
                try
                {

                    Insertsale.ExecuteNonQuery();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sc.Close();
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
