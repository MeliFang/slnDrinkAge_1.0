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
        Dictionary<string, string> _Dic_AnyTypeForUpdate = new Dictionary<string, string>();
        List<string> User_com_value;
        internal void MemUpdate(string value,string Column,int index)
        {
            if (User_com_value == null)
            {
                
            }
            Member Mem = (from m in dbContext.Members
                          where m.MemberID == index + 1
                          select m).FirstOrDefault();
            if (Mem == null)
            {
                return;
            }
            else
            {
                
                Mem.Account = value;
                dbContext.SaveChanges();
            }

        }
    }
}
