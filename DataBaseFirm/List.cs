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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmDataSet.list_of_goods' table. You can move, or remove it, as needed.
            this.list_of_goodsTableAdapter.Fill(this.firmDataSet.list_of_goods);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Warehouse1 w1 = new Warehouse1();
            w1.Show();
            this.Hide();
        }
    }
}
