using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAge_1._0.ClassOfConsole
{
    class Up_To_SqlData
    {
        DrinkAgeEntities dbContext = new DrinkAgeEntities();
        internal void MemUpdate(Dictionary<string, string> MemCGV,int index)
        {

            Member Mem = (from m in dbContext.Members
                      where m.MemberID == index
                      select m).FirstOrDefault();
            PropertyInfo[] MemProperty = Mem.GetType().GetProperties();
            for (int i = 0; MemProperty.Count() > i; i++)
            {

                if (MemCGV.ContainsKey(MemProperty[i].Name.ToString()))
                {
                    if (Mem.GetType().GetProperty(MemProperty[i].Name).PropertyType.Name == "String")
                    {
                        Mem.GetType().GetProperty(MemProperty[i].Name).SetValue(Mem, MemCGV[MemProperty[i].Name], null);
                    }
                    else
                    {
                        switch(MemProperty[i].Name)
                        {
                            case "Level":
                                Mem.GetType().GetProperty(MemProperty[i].Name).SetValue(Mem, int.Parse(MemCGV[MemProperty[i].Name]), null);
                                break;
                            case "Exp":
                                Mem.GetType().GetProperty(MemProperty[i].Name).SetValue(Mem, int.Parse(MemCGV[MemProperty[i].Name]), null);
                                break;
                            case "Point":
                                Mem.GetType().GetProperty(MemProperty[i].Name).SetValue(Mem, int.Parse(MemCGV[MemProperty[i].Name]), null);
                                break;
                            case "ACHVID":
                                Mem.GetType().GetProperty(MemProperty[i].Name).SetValue(Mem, int.Parse(MemCGV[MemProperty[i].Name]), null);
                                break;
                            case "Birth":
                                Mem.GetType().GetProperty(MemProperty[i].Name).SetValue(Mem, Convert.ToDateTime(MemCGV[MemProperty[i].Name]), null);
                                break;
                        }
                    } 
                }
            }
            dbContext.SaveChanges();
        }
        internal void MemimgtoTable(Byte[] imgBinary, int MemID)
        {
            Member Mem = (from m in dbContext.Members
                          where m.MemberID == MemID
                          select m).FirstOrDefault();
            Mem.MemberPIC = imgBinary;
            dbContext.SaveChanges();
        }
    }
}
