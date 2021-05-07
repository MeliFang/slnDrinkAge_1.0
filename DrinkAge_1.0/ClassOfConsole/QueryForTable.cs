using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAge_1._0.ClassOfConsole
{
    class QueryForTable
    {
        DrinkAgeEntities dbContext = new DrinkAgeEntities();
        Dictionary<string, string> _DIC_AnyTypeForQuery = new Dictionary<string, string>();
        List<string> ComText;
        IQueryable<Member> Member;
        
        internal IQueryable<Member> MemberQueryAll()
        {
            
            Member = from x in dbContext.Members
                                        select x;
            return Member;
        }
        internal IQueryable<Member> ConditionOfMember(List<string> Comvle,string Condition,string userValue)
        {
            if (ComText==null)
            {
                ComText = Comvle;
                for (int i = 0; i < ComText.Count; i++)
                {
                    _DIC_AnyTypeForQuery.Add(ComText[i], $"M{i}");
                }
            }
            if (true == _DIC_AnyTypeForQuery.ContainsKey(Condition))
            {

                if (_DIC_AnyTypeForQuery[Condition] == "M0")
                {
                    Member = from x in dbContext.Members
                             where x.MemberID.ToString() == userValue
                             select x;
                }
                else if (_DIC_AnyTypeForQuery[Condition] == "M1")
                {
                    Member = from x in dbContext.Members
                             where x.Account == userValue
                             select x;
                }
                else if (_DIC_AnyTypeForQuery[Condition] == "M2")
                {
                    Member = from x in dbContext.Members
                             where x.Password == userValue
                             select x;
                }
                else if (_DIC_AnyTypeForQuery[Condition] == "M3")
                {
                    Member = from x in dbContext.Members
                             where x.NickName.Contains(userValue)
                             select x;
                }
                else if (_DIC_AnyTypeForQuery[Condition] == "M4")
                {
                    Member = from x in dbContext.Members
                             where x.Gender.Contains(userValue)
                             select x;
                }
                else if (_DIC_AnyTypeForQuery[Condition] == "M5")
                {
                    Member = from x in dbContext.Members
                             where x.Email == userValue
                             select x;
                }
                else if (_DIC_AnyTypeForQuery[Condition] == "M6")
                {
                    Member = from x in dbContext.Members
                             where x.Birth.ToString().Contains(userValue)
                             select x;
                }
                else if (_DIC_AnyTypeForQuery[Condition] == "M7")
                {
                    Member = from x in dbContext.Members
                             where x.Phone.ToString() == userValue
                             select x;
                }
                else if (_DIC_AnyTypeForQuery[Condition] == "M8")
                {
                    Member = from x in dbContext.Members
                             where x.Level.ToString().Contains(userValue)
                             select x;
                }
                else if (_DIC_AnyTypeForQuery[Condition] == "M9")
                {
                    Member = from x in dbContext.Members
                             where x.Exp.ToString().Contains(userValue)
                             select x;
                }
                else if (_DIC_AnyTypeForQuery[Condition] == "M10")
                {
                    Member = from x in dbContext.Members
                             where x.Point.ToString().Contains(userValue)
                             select x;
                }
                else if (_DIC_AnyTypeForQuery[Condition] == "M11")
                {
                    Member = from x in dbContext.Members
                             where x.ACHVID.ToString().Contains(userValue)
                             select x;
                }
                else
                {
                    return null;
                }


            }
            return Member;
        }
        
    }
}
