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
            List<string> comparison = new List<string>() { "Password", "MemberPIC", "Exp", "Point","ACHVName" };
            List<string> Com = new List<string>();
            DataGridView Header = sender as DataGridView;
            bool difference = true;
            for (int i = 0; i < Header.ColumnCount; i++)
            {
                foreach (var j in comparison)
                {
                    if (Header.Columns[i].HeaderText == j)
                    {
                        difference = false;
                        break;
                    }
                    else
                    {
                        difference = true;
                    }
                }
                if (difference)
                {
                    Com.Add(Header.Columns[i].HeaderText);
                }
            }
            Comvle = Com;
            return Comvle;
        }
        internal Dictionary<string, string> DataRowstoValue(object sender)
        {
            List<string> comparison = new List<string>() {"MemberID","Password","MemberPIC"};
            DataGridView Row = sender as DataGridView;
            Dictionary<string,string> MemRowisValue = new Dictionary<string, string>();
            int i = Row.CurrentCell.RowIndex;
            bool difference=true;
            for (int x = 0; Row.Columns.Count > x; x++)
            {
                foreach (var j in comparison)
                {
                    if (Row.Columns[x].HeaderText == j)
                    {
                        difference = false;
                        break;
                    }
                    else
                    {
                        difference = true;
                    }
                        
                }
                if (difference)
                    MemRowisValue.Add(Row.Columns[x].HeaderText, Row.Rows[i].Cells[x].Value.ToString());
            }
            return MemRowisValue;
        }
    }
    
}
