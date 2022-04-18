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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sales sl = new Sales();
            sl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Goods gd = new Goods();
            gd.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Warehouse1 w1 = new Warehouse1();
            w1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Warehouse2 w2 = new Warehouse2();
            w2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
    }
}
