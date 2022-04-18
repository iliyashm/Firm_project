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
    public partial class Adding_user : Form
    {
        PgSqlConnection sc = new PgSqlConnection(@"User Id=postgres;Host=localhost;Database=Firm;Password=12345;Persist Security Info=True;Initial Schema=public");
        PgSqlCommand cmd = new PgSqlCommand(); 
        public Adding_user()
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

        private void Adding_user_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmDataSet.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.firmDataSet.users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc.Open();
            try
            {
                if (passwordTextBox.Text != "" && usernameTextBox.Text != "" && roleTextBox.Text != "")
                {
                    PgSqlCommand Insertgood = new PgSqlCommand("insert into users (username,password,role) values ('" + usernameTextBox.Text + "',crypt('" + passwordTextBox.Text + "', gen_salt('md5')),'" + roleTextBox.Text + "');", sc);
                    Insertgood.ExecuteNonQuery();
                    MessageBox.Show("Пользователь успешно добавлен.", "Добавление пользователя", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Все строки должны быть заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sc.Close();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administration ad = new Administration();
            ad.Show();
            this.Hide();
        }
    }
}
