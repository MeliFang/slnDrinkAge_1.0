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
        internal List<string> Comvle{ get; set;}
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

        internal string DataRowstoValue(object sender, DataGridViewCellEventArgs o)
        {
            DataGridView Row = sender as DataGridView;
            int i = Row.CurrentCell.RowIndex;
            int j = Row.CurrentCell.ColumnIndex;
            string RV = Row.Rows[i].Cells[j].Value.ToString();
            return RV;
        }
        internal string DataColumnstoValue(object sender, DataGridViewCellEventArgs o)
        {
            DataGridView Column = sender as DataGridView;
            int j = Column.CurrentCell.ColumnIndex;
            string CV = Column.Columns[j].HeaderText;
            return CV;
        }
    }
}
