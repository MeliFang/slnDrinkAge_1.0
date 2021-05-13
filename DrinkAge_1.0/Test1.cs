using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkAge_1._0
{
    public partial class Test1 : Form
    {
        public Test1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrinkAgeEntities dbContext = new DrinkAgeEntities();
            string MemAcvName = (from i in dbContext.MemberACHVs
                                 where i.ACHVID == 5
                                 select i.Achievement.ACHVName).FirstOrDefault();
            MessageBox.Show(MemAcvName);

        }
    }
}
