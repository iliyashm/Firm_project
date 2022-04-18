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
    public partial class Form1 : Form
    {
        PgSqlConnection sc = new PgSqlConnection(@"User Id=postgres;Host=localhost;Database=Firm;Password=12345;Persist Security Info=True;Initial Schema=public");
        PgSqlCommand cmd = new PgSqlCommand(); 
        public Form1()
        {
            InitializeComponent();
            cmd.Connection = sc;
            
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.firmDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmDataSet.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.firmDataSet.users);

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc.Open();
            //MessageBox.Show(dl.getmessage, "Check Connection");
            string role = null;
            cmd.CommandText = "Select role from users where username = '" + usernameTextBox.Text + "' and password = crypt('"+ passwordTextBox.Text +"', password)";
            using (PgSqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    role = reader["role"].ToString();
                }
            }
            if (role == "user")
            {
                User us = new User();
                us.Show();
                this.Hide();
            }
            else if (role == "admin")
            {
                Administration ad = new Administration();
                ad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Вы ввели неправильный логин или пароль. Попробуйте снова");
            }
            sc.Close();
        }
    }
}
