using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAge_1._0.ClassOfConsole
{
    class UpdateFortable
    {
        DrinkAgeEntities dbContext = new DrinkAgeEntities();
        internal void MemUpdate(Dictionary<string, string> MemCGV,int index)
        {

            //var Mem = from m in dbContext.Members.
            //          where m.MemberID==1
            //          select m;


            //if (Mem == null)
            //{
            //    return;
            //}
            //else
            //{
            //    Mem.Account = value;
            //    dbContext.SaveChanges();
            //}

        }
    }
}
