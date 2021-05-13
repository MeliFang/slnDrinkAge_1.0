using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAge_1._0.ClassOfConsole
{
    class Close_Open_Data
    {
        internal void MemDataDe_T_F(int index,bool mode)
        {
            DrinkAgeEntities dbContext = new DrinkAgeEntities();
            Member Mem = (from i in dbContext.Members
                          where i.MemberID == index
                          select i).FirstOrDefault();
            //Mem.display = mode;
            dbContext.SaveChanges();
        }
    }
}
