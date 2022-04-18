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
    public partial class Administration : Form
    {
        PgSqlConnection sc = new PgSqlConnection(@"User Id=postgres;Host=localhost;Database=Firm;Password=12345;Persist Security Info=True;Initial Schema=public");
        PgSqlCommand cmd = new PgSqlCommand(); 
        public Administration()
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

        private void Administration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.firmDataSet.users);

        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adding_user adu = new Adding_user();
            adu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usersDataGridView.CurrentRow.Selected == true && !usersDataGridView.CurrentRow.IsNewRow)
            {
                sc.Open();
                DialogResult res = MessageBox.Show("Вы действительно хотите удалить данного сотрудника?", "Удаление сотрудника", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                switch (res)
                {
                    case DialogResult.OK:

                        PgSqlCommand deleteuser = new PgSqlCommand("DELETE FROM users WHERE id = '" + Convert.ToInt32(usersDataGridView.CurrentRow.Cells[2].Value)+ "'", sc);


                        //deleteuser.Parameters.AddWithValue("Id", Convert.ToInt32(usersDataGridView.CurrentRow.Cells[2].Value));
                        try
                        {
                            deleteuser.ExecuteNonQuery();
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
                sc.Close();
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужного сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.firmDataSet.users);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
    }
}
