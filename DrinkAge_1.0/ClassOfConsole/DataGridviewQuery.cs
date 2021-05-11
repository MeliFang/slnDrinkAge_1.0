using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkAge_1._0.ClassOfConsole
{
    class DataGridviewQuery
    {
        internal List<string> Comvle;
        internal List<string> DGColumntoCom(object sender)
        {
            List<string> Com = new List<string>();
            DataGridView Header = sender as DataGridView;
            for (int i = 0; i < Header.ColumnCount; i++)
            {
                if (Header.Columns[i].HeaderText != "MemberPIC")
                {
                    Com.Add(Header.Columns[i].HeaderText);
                }
            }
            Comvle = Com;
            return Comvle;
        }
        internal Dictionary<string, string> DataRowstoValue(object sender)
        {
            DataGridView Row = sender as DataGridView;
            Dictionary<string,string> MemRowisValue = new Dictionary<string, string>();
            int i = Row.CurrentCell.RowIndex;
            for (int x = 0; Row.Columns.Count > x; x++)
            {
                if (Row.Columns[x].HeaderText != "MemberPIC")
                {
                    MemRowisValue.Add(Row.Columns[x].HeaderText, Row.Rows[i].Cells[x].Value.ToString());
                }
            }
            return MemRowisValue;
        }
        
    }
}
