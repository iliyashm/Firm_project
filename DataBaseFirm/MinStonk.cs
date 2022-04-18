using System;
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
    public partial class MinStonk : Form
    {
        public MinStonk()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                object minstonk;
                this.min_stonkTableAdapter.Fill(this.firmDataSet.min_stonk, min_dateToolStripTextBox.Text, max_dateToolStripTextBox.Text, out minstonk);
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
