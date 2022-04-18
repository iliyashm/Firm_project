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
    public partial class Top5Month : Form
    {
        public Top5Month()
        {
            InitializeComponent();
        }

        private void Top5Month_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmDataSet.top_5_month' table. You can move, or remove it, as needed.
            this.top_5_monthTableAdapter.Fill(this.firmDataSet.top_5_month);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Goods gd = new Goods();
            gd.Show();
            this.Hide();
        }
    }
}
