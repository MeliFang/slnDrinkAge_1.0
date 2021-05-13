using DrinkAge_1._0.ClassOfConsole;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Generic;

namespace DrinkAge_1._0
{
    public partial class LangCotrol : Form
    {
        QueryForTable QueryTowhere;
        DataGridviewQuery DataGQ;
        UpdateFortable UpForTa;
        public LangCotrol()
        {
            InitializeComponent();
            DataGQ = new DataGridviewQuery();
            QueryTowhere = new QueryForTable();
            UpForTa = new UpdateFortable();

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
            combo=DataGQ.DGColumntoCom(dataGridView1);
            foreach (var i in combo)
            {
                ComboboxCondT.Items.Add(i);
            }
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
            TBCT=TBMemRVchange.Text;
            UpForTa.MemUpdate(TBCT,DGVC,bindingSource1.Position);
            Mem = QueryTowhere.ConditionOfMember(combo, ComboboxCondT.Text, TextboxCondValue.Text);
            bindingSource1.DataSource = Mem.ToList();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            TBMemRVchange.Text="";

        }
        string DGVR;
        string DGVC;
        string TBCT;
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TextboxCondValue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVR=DataGQ.DataRowstoValue(sender, e);
            LabelMemRow.Text = DGVR;
            DGVC = DataGQ.DataColumnstoValue(sender, e);
            LabelMemColum.Text = DGVC;
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
    }
}
