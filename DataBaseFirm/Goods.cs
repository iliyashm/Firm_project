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
    public partial class Goods : Form
    {
        PgSqlConnection sc = new PgSqlConnection(@"User Id=postgres;Host=localhost;Database=Firm;Password=12345;Persist Security Info=True;Initial Schema=public");
        PgSqlCommand cmd = new PgSqlCommand();
        public Goods()
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

        private void Goods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmDataSet.goods' table. You can move, or remove it, as needed.
            this.goodsTableAdapter.Fill(this.firmDataSet.goods);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User us = new User();
            us.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.goodsTableAdapter.FillByName(this.firmDataSet.goods);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NotinWareH1 nw = new NotinWareH1();
            nw.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (goodsDataGridView.CurrentRow.Selected == true && !goodsDataGridView.CurrentRow.IsNewRow)
            {
                sc.Open();

                string result = null;
                cmd.CommandText = "select distinct Sum(warehouse1.good_count + warehouse2.good_count) as Ready_for_sale from goods,warehouse1,warehouse2 where (goods.id = warehouse1.good_id and warehouse2.good_id = goods.id) and goods.name = '" + (goodsDataGridView.CurrentRow.Cells[1].Value).ToString() + "'";

                using (PgSqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        textBox1.Clear();
                        result = reader["Ready_for_sale"].ToString();
                        if (result == "")
                        {
                            textBox1.Paste("0");
                        }
                        else
                        {
                            textBox1.Paste(reader["Ready_for_sale"].ToString());
                        }
                    }
                }
                      
                
                sc.Close();
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужный товар", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TopGoods tg = new TopGoods();
            tg.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InsertGood ig = new InsertGood();
            ig.Show();
            //this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.goodsTableAdapter.Fill(this.firmDataSet.goods);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InsertWarehouses iw = new InsertWarehouses();
            iw.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (goodsDataGridView.CurrentRow.Selected == true && !goodsDataGridView.CurrentRow.IsNewRow)
            {
                sc.Open();


                PgSqlCommand Deletegood = new PgSqlCommand("delete from goods where goods.id = '" + Convert.ToInt32(goodsDataGridView.CurrentRow.Cells[0].Value) + "'", sc);
                PgSqlCommand Deletesales = new PgSqlCommand("delete from sales where sales.good_id = '" + Convert.ToInt32(goodsDataGridView.CurrentRow.Cells[0].Value) + "'", sc);
                PgSqlCommand deletewh1 = new PgSqlCommand("delete from warehouse1 where good_id = '" + Convert.ToInt32(goodsDataGridView.CurrentRow.Cells[0].Value) + "'", sc);
                PgSqlCommand deletewh2 = new PgSqlCommand("delete from warehouse2 where good_id = '" + Convert.ToInt32(goodsDataGridView.CurrentRow.Cells[0].Value) + "'", sc);
                try
                {
                    Deletegood.ExecuteNonQuery();
                    deletewh1.ExecuteNonQuery();
                    deletewh2.ExecuteNonQuery();
                    Deletesales.ExecuteNonQuery();
                    
                    //Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //sc.Close();
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужный товар", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GoodsinWarehouse1 gw = new GoodsinWarehouse1();
            gw.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Top5Month t5 = new Top5Month();
            t5.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sc.Open();
            PgSqlCommand deletewh1 = new PgSqlCommand("delete from warehouse1 where good_id in (select id from goods where goods.id not in (select good_id from sales));", sc);
            PgSqlCommand deletewh2 = new PgSqlCommand("delete from warehouse2 where good_id in (select id from goods where goods.id not in (select good_id from sales));", sc);
            PgSqlCommand deletegood = new PgSqlCommand("delete from goods where goods.id not in (select good_id from sales);", sc);
            try
            {
                deletewh1.ExecuteNonQuery();
                deletewh2.ExecuteNonQuery();
                deletegood.ExecuteNonQuery();
                //Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //sc.Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (goodsDataGridView.CurrentRow.Selected == true && !goodsDataGridView.CurrentRow.IsNewRow)
            {
                if (textBox2.Text != "")
                {
                    sc.Open();
                    PgSqlCommand updatepriority = new PgSqlCommand("update goods set priority = '" + textBox2.Text + "' where goods.id = '" + Convert.ToInt32(goodsDataGridView.CurrentRow.Cells[0].Value) + "'", sc);

                    try
                    {
                        updatepriority.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //sc.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужный товар", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
