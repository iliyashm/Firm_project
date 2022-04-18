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
    public partial class InsertSale : Form
    {
        PgSqlConnection sc = new PgSqlConnection(@"User Id=postgres;Host=localhost;Database=Firm;Password=12345;Persist Security Info=True;Initial Schema=public");
        PgSqlCommand cmd = new PgSqlCommand(); 
        public InsertSale()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void salesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.firmDataSet);

        }

        private void InsertSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmDataSet.sales' table. You can move, or remove it, as needed.
            //this.salesTableAdapter.Fill(this.firmDataSet.sales);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (good_idTextBox.Text != "" && good_countTextBox.Text != "")
            {
                sc.Open();
                PgSqlCommand Insertsale = new PgSqlCommand("insert into sales (GOOD_ID,GOOD_COUNT,CREATE_DATE) values ('" + Convert.ToInt32(good_idTextBox.Text) + "','" + Convert.ToInt32(good_countTextBox.Text) + "','" + Convert.ToDateTime(create_dateDateTimePicker.Text) + "')", sc);
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
