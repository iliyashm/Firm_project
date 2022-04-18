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
    public partial class GoodsinWarehouse1 : Form
    {
        public GoodsinWarehouse1()
        {
            InitializeComponent();
        }

        private void GoodsinWarehouse1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmDataSet.goods_in_warehouse1' table. You can move, or remove it, as needed.
            this.goods_in_warehouse1TableAdapter.Fill(this.firmDataSet.goods_in_warehouse1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Goods gd = new Goods();
            gd.Show();
            this.Hide();
        }
    }
}
