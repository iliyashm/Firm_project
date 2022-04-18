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
    public partial class InsertGood : Form
    {
        PgSqlConnection sc = new PgSqlConnection(@"User Id=postgres;Host=localhost;Database=Firm;Password=12345;Persist Security Info=True;Initial Schema=public");
        PgSqlCommand cmd = new PgSqlCommand(); 
        public InsertGood()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void goodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.goodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.firmDataSet);

        }

        private void InsertGood_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmDataSet.goods' table. You can move, or remove it, as needed.
            //this.goodsTableAdapter.Fill(this.firmDataSet.goods);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && priorityTextBox.Text != "")
            {
                sc.Open();
                PgSqlCommand Insertgood = new PgSqlCommand("insert into goods (Name,Priority) values ('" + nameTextBox.Text + "','" + priorityTextBox.Text + "')", sc);
                try
                {
                    
                    Insertgood.ExecuteNonQuery();
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
