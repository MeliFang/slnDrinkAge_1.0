using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace DrinkAge_1._0
{
    public partial class FrmIndex : Form
    {
        public FrmIndex()
        {
            InitializeComponent();
            timer1.Enabled = true;
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
        private int IndexPicure;
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            IndexPicure = IndexPicure + 1;
            if (IndexPicure >= 3)
                IndexPicure = -1;
            if (IndexPicure == 0)
            {
                this.IndexPic.Image = Image.FromFile("C:\\Users\\User\\Documents\\GitHub\\slnDrinkAge_1.0\\DrinkAge_1.0\\image\\img_ad\\ad_01.jpg");
                //this.IndexPic.Image = Image.FromFile("E:\\CSharp_Course\\DrinkAge\\Winform\\0512\\0512\\slnDrinkAge_1.0\\DrinkAge_1.0\\image\\Img_Ad\\ad_01.jpg");
                timer1.Interval = 3000;
            //E:\CSharp_Course\DrinkAge\Winform\0512\0512\slnDrinkAge_1.0\DrinkAge_1.0\image\Img_Ad
            }
            else if (IndexPicure == 1)
            {
                this.IndexPic.Image = Image.FromFile("C:\\Users\\User\\Documents\\GitHub\\slnDrinkAge_1.0\\DrinkAge_1.0\\image\\img_ad\\ad_02.jpg");
                //this.IndexPic.Image = Image.FromFile("E:\\CSharp_Course\\DrinkAge\\Winform\\0512\\0512\\slnDrinkAge_1.0\\DrinkAge_1.0\\image\\Img_Ad\\ad_02.jpg");
               
                timer1.Interval = 3000;
            }
            else if (IndexPicure == 2)
            {
                this.IndexPic.Image = Image.FromFile("C:\\Users\\User\\Documents\\GitHub\\slnDrinkAge_1.0\\DrinkAge_1.0\\image\\img_ad\\ad_03.jpeg");
                //this.IndexPic.Image = Image.FromFile("E:\\CSharp_Course\\DrinkAge\\Winform\\0512\\0512\\slnDrinkAge_1.0\\DrinkAge_1.0\\image\\Img_Ad\\ad_03.jpeg");
                timer1.Interval = 3000;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] items = Regex.Split(textBox1.Text, "\r\n");
            listBox2.Items.AddRange(items);
        }
    }
}
