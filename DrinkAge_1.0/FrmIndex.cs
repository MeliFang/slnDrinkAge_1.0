using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkAge_1._0
{
    public partial class FrmIndex : Form
    {
        public FrmIndex()
        {
            InitializeComponent();
        }



        private void btnLuck_Click(object sender, EventArgs e)
        {
            FrmLuck f = new FrmLuck();
            f.Show();
            MessageBox.Show("");
        }

        private void FrmIndex_Load(object sender, EventArgs e)
        {
            listBox6.Items.Add("瀏覽紀錄");
            listBox6.Items.Add("炸彈檸檬的滋味-夏天不喝檸檬真的就是out fashion了...");
            listBox6.Items.Add("波哥好飲TOP10");
            listBox6.Items.Add("水巷茶弄TOP10");

            listBox7.Items.Add("我的收藏");
            listBox7.Items.Add("番茄冰沙製作秘訣");
            listBox7.Items.Add("五十嵐不能說的秘密");

            listBox5.Items.Add("文章列表");
            listBox5.Items.Add("五十嵐不能說的秘密");
            listBox5.Items.Add("可不可行銷術");

            listBox3.Items.Add("熱門評論");
            listBox3.Items.Add("芒果綠冰沙-除了芒果果香外，還喝的到茶味，挺特別的");
            listBox3.Items.Add("50嵐-四季珍波椰");

            listBox4.Items.Add("熱門周邊商品");
            listBox4.Items.Add("五十嵐棒球帽");
            listBox4.Items.Add("Comebuy托特包");
            listBox4.Items.Add("可不可聯名杯套");

            listBox8.Items.Add("新品上市");
            listBox8.Items.Add("Comeby-黃金奶綠");
            listBox8.Items.Add("清心福全-鳳梨冰茶");

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
