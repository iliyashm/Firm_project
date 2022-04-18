using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataBaseFirm
{
    public partial class Max_Stonk : Form
    {
        public Max_Stonk()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                object maxstonk;
                this.max_stonkTableAdapter.Fill(this.firmDataSet.max_stonk, min_dateToolStripTextBox.Text, max_dateToolStripTextBox.Text,out maxstonk);
                string data = max_stonkDataGridView[0, 0].Value.ToString();
                FileInfo f = new FileInfo("Max_stonk_out.txt");
                StreamWriter writer = f.CreateText();
                writer.WriteLine("Максимальный спрос на товар:");
                writer.Write(writer.NewLine);
                writer.WriteLine("Наименование товара: " + data);
                writer.Write(writer.NewLine);
                writer.Close();
                MessageBox.Show("Таблица успешно сохранена в: Max_stonk_out.txt");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Неправильно заданная дата(год-месяц-день)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
