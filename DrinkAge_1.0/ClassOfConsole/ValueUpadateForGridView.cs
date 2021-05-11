using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkAge_1._0.ClassOfConsole
{
    class ValueUpadateForGridView
    {
        internal DataGridView UserVUpdateToGridV(DataGridView v,Dictionary<string,string> d)
        {
            int i = v.CurrentCell.RowIndex;
            for (int x = 0; v.Columns.Count > x; x++)
            {
                if ((v.Rows[i].Cells[x].Value).ToString() != (d[v.Columns[x].HeaderText]))
                {
                    //MemDGV.Rows[i].Cells[x].Value = d[v.Columns[x].HeaderText];
                    v.Rows[i].Cells[x].Style.BackColor = Color.Orange;
                }
            }
            return v;

        }
    }
}
