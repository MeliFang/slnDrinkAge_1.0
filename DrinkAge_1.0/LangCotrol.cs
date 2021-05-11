﻿using DrinkAge_1._0.ClassOfConsole;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DrinkAge_1._0
{
    public partial class LangCotrol : Form
    {
        QueryForTable QueryTowhere;
        DataGridviewQuery DataGQ;
        UpdateFortable UpForTa;
        ValueUpadateForGridView VudForGrid;
        public LangCotrol()
        {
            InitializeComponent();
            DataGQ = new DataGridviewQuery();
            QueryTowhere = new QueryForTable();
            UpForTa = new UpdateFortable();
            VudForGrid = new ValueUpadateForGridView();

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        IQueryable<Member> Mem;
        List<string> combo;
        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1 = QueryTowhere.MemberQueryAll();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            if(combo==null)
            {
                combo = DataGQ.DGColumntoCom(dataGridView1);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (TextboxCondValue.Text == "" || ComboboxCondT.Text == "")
            {
                MessageBox.Show("請在選擇搜索條件與輸入您要查詢的條件內容");
            }
            else
            {
                Mem = QueryTowhere.ConditionOfMember(combo,ComboboxCondT.Text,TextboxCondValue.Text);
                if (Mem == null || Mem.ToList().Count() == 0)
                {
                    MessageBox.Show("查無此資料");
                }
                else
                {
                    bindingSource1.DataSource = Mem.ToList();
                    bindingNavigator1.BindingSource = bindingSource1;
                    dataGridView1.DataSource = bindingSource1;
                }
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //TBCT = TxTBMemID.Text;
            //UpForTa.MemUpdate(TBCT, DGVC, bindingSource1.Position);
            //Mem = QueryTowhere.ConditionOfMember(combo, ComboboxCondT.Text, TextboxCondValue.Text);
            //bindingSource1.DataSource = Mem.ToList();
            //bindingNavigator1.BindingSource = bindingSource1;
            //dataGridView1.DataSource = bindingSource1;
            //TxTBMemID.Text = "";

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
            MemisRV=DataGQ.DataRowstoValue(sender);
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

        private void button4_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> MemRVCG = new Dictionary<string, string>();
            int i = dataGridView1.CurrentCell.RowIndex;
            int MemID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
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
            //int i = dataGridView1.CurrentCell.RowIndex;
            //for (int x = 0; dataGridView1.Columns.Count > x; x++)
            //{
            //    if (dataGridView1.Columns[x].HeaderText == MemRVCG.ContainsKey(dataGridView1.Columns[x].HeaderText).ToString())
            //    {
            //        if ((dataGridView1.Rows[i].Cells[x].Value).ToString() != (MemRVCG[dataGridView1.Columns[x].HeaderText]))
            //        {
            //            dataGridView1.Rows[i].Cells[x].Style.BackColor = Color.Orange;
            //        }
            //    }
            //}
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            MemisRV = DataGQ.DataRowstoValue(sender);
            dataGridViewtopanel();
        }
        Dictionary<string, string> MemRVCGtoM;
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
            }
        }
    }
}
