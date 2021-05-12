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
            Member w = new Member();
            var x = (from g in dbContext.Members
                    where g.MemberID == 1
                    select g).FirstOrDefault();
            PropertyInfo[] q=x.GetType().GetProperties();
            for (int i = 0; q.Count() > i; i++)
            {
                MessageBox.Show(x.GetType().GetProperty(q[i].Name).PropertyType.Name);
            }
            
        }
    }
}
