using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DataBaseFirm
{
    public partial class Spros : Form
    {
        public Spros()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.max_priority_21TableAdapter.FillBy(this.firmDataSet._max_priority_21, goodname1ToolStripTextBox.Text, goodname2ToolStripTextBox.Text,Convert.ToInt32(toolStripTextBox1.Text));
                string data = max_priority_21DataGridView[0, 0].Value.ToString();
                FileInfo f = new FileInfo("Sprosout.txt");
                StreamWriter writer = f.CreateText();
                writer.WriteLine("Прогноз спрорса на заданный товар:");
                writer.Write(writer.NewLine);
                writer.WriteLine("Id товара: " + toolStripTextBox1.Text + ".");
                writer.Write(writer.NewLine);
                writer.WriteLine("Прирост спроса: "+ data);
                writer.Write(writer.NewLine);
                writer.Close();
                MessageBox.Show("Таблица успешно сохранена в: Sprosout.txt");



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
