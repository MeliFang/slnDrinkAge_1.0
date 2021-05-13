using DrinkAge_1._0.ClassOfConsole;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DrinkAge_1._0
{
    public partial class LangCotrol : Form
    {
        Query_To_Table Query_To_SqlTable;
        DataGridviewQuery DataGrid_Query;
        Up_To_SqlData Up_To_SqlTable;
        Close_Open_Data T_or_F_to_Data;
        DrinkAgeEntities dbContext = new DrinkAgeEntities();
        public LangCotrol()
        {
            InitializeComponent();
            DataGrid_Query = new DataGridviewQuery();
            Query_To_SqlTable = new Query_To_Table();
            Up_To_SqlTable = new Up_To_SqlData();
            T_or_F_to_Data = new Close_Open_Data();
            this.MemberPIC.AllowDrop = true;
            this.MemberPIC.DragDrop += PictureBox2_DragDrop;
            this.MemberPIC.DragEnter += PictureBox2_DragEnter;


        }

        private void PictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void PictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            string[] x = (string[])e.Data.GetData(DataFormats.FileDrop);
            MemberPIC.Image = Image.FromFile(x[0]);
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        List<string> combo;
        private void button1_Click(object sender, EventArgs e)//總會員顯示
        {
            bindingSource1 = Query_To_SqlTable.MemberQueryAllorcondition();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            if(combo==null)
            {
                combo = DataGrid_Query.DGColumntoCom(dataGridView1);
                foreach (var i in combo)
                {
                    ComboboxCondT.Items.Add(i);
                }
            }
            foreach (var x in TBpanel.Controls)
            {
                if (x.GetType() == typeof(TextBox))
                {

                    (x as TextBox).Text = "";
                }
            }
            dataGridView1_SelectionChanged(dataGridView1, e);

        }

        private void button2_Click(object sender, EventArgs e)//條件搜索
        {
            if (TextboxCondValue.Text == "" || ComboboxCondT.Text == "")
            {
                MessageBox.Show("請在選擇搜索條件與輸入您要查詢的條件內容");
            }
            else
            {
                bindingSource1 = Query_To_SqlTable.ConditionOfMember(combo,ComboboxCondT.Text,TextboxCondValue.Text);
                if (bindingSource1 == null)
                {
                    MessageBox.Show("查無此資料");
                }
                else
                {
                    bindingNavigator1.BindingSource = bindingSource1;
                    dataGridView1.DataSource = bindingSource1;
                }
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)//儲存圖片到sql
        {
            Byte[] Bt;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.MemberPIC.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            Bt = ms.GetBuffer();
            Up_To_SqlTable.MemimgtoTable(Bt, MemID);
            DataViewAgain(MemID);
            dataGridViewtopanel();
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TextboxCondValue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            
        }
        Dictionary<string, string> MemisRV;
        private void dataGridView1_CellClickled(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            MemID = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
            MemisRV =DataGrid_Query.DataRowstoValue(sender);
            dataGridViewtopanel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboboxCondT_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void ComboboxCondT_TextChanged(object sender, EventArgs e)
        {
            TextboxCondValue.Text = "";
        }
        int MemID;
        private void button4_Click(object sender, EventArgs e)//儲存資料到sql
        {
            Dictionary<string, string> MemRVCG = new Dictionary<string, string>();
            foreach (var x in TBpanel.Controls)
            {
                if (x.GetType() == typeof(TextBox))
                {
                    if (MemisRV.ContainsKey((x as TextBox).Name))
                    {
                        if ((x as TextBox).Text != MemisRV[(x as TextBox).Name])
                        {
                            MemRVCG.Add((x as TextBox).Name, (x as TextBox).Text);
                        }
                    }
                }
            }
            Up_To_SqlTable.MemUpdate(MemRVCG, MemID);
            DataViewAgain(MemID);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            MemID = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
            MemisRV = DataGrid_Query.DataRowstoValue(sender);
            dataGridViewtopanel();
        }
        private void dataGridViewtopanel()
        {
            foreach (var x in TBpanel.Controls)
            {
                if (x.GetType() == typeof(TextBox))
                {
                    if (MemisRV.ContainsKey((x as TextBox).Name))
                    {
                        (x as TextBox).Text = MemisRV[(x as TextBox).Name];
                    }
                }
                else if (x.GetType() == typeof(ComboBox))
                {
                    if (MemisRV.ContainsKey((x as ComboBox).Name))
                        (x as ComboBox).Text = MemisRV[(x as ComboBox).Name];
                }
            }
           byte[] img =Query_To_SqlTable.Mem_img_Picture(MemID);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
            this.MemberPIC.Image = Image.FromStream(ms);
            List<string> MemACHVID = Query_To_SqlTable.Mem_ACHVID_Combo(MemID);
            ACHVID.Items.Clear();
            foreach (var q in MemACHVID)
            {
                ACHVID.Items.Add(q);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)//從uesr端取得圖片
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.MemberPIC.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool Mem_mode = true;
            if (comboBox1.Text == "open")
            {
                Mem_mode = true;
            }
            else
            {
                Mem_mode = false;
            }
            T_or_F_to_Data.MemDataDe_T_F(MemID, Mem_mode);
            DataViewAgain(MemID);

        }
        private void DataViewAgain(int index)
        {
            bindingSource1 = Query_To_SqlTable.MemberQueryAllorcondition(MemID);
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
        }

        private void ACHVID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ACHVID_TextChanged_1(object sender, EventArgs e)
        {
            int i = int.Parse(ACHVID.Text);
            var MemAN = (from n in dbContext.Achievements
                         where n.ACHVID == i
                         select new { n.ACHVName }).FirstOrDefault();
            ACHVName.Text = MemAN.ACHVName.ToString();

        }
    }
}
