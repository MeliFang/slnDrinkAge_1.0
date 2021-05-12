using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkAge_1._0.ClassOfConsole
{
    class QueryForTable
    {
        DrinkAgeEntities dbContext = new DrinkAgeEntities();
        Dictionary<string, string> _DIC_AnyTypeForQuery = new Dictionary<string, string>();
        List<string> ComText;
        IQueryable<Member> Member;

        internal BindingSource MemberQueryAllorcondition()
        {
            var NMem = from x in dbContext.Members
                       select new { 
                           MemberID = x.MemberID, 
                           Account = x.Account, 
                           Password = x.Password, 
                           MemberPIC = x.MemberPIC, 
                           NickName = x.NickName, 
                           Gender = x.Gender, 
                           Email = x.Email, 
                           Birth = x.Birth, 
                           Phone = x.Phone, 
                           Level = x.Level, 
                           Exp = x.Exp, 
                           Point = x.Point, 
                           ACHVID = x.ACHVID };
            BindingSource BSMem = new BindingSource();
            BSMem.DataSource = NMem.ToList();
            return BSMem;
        }
        internal BindingSource MemberQueryAllorcondition(int index)
        {
            var NMem = from x in dbContext.Members
                       where x.MemberID==index
                       select new
                       {
                           MemberID = x.MemberID,
                           Account = x.Account,
                           Password = x.Password,
                           MemberPIC = x.MemberPIC,
                           NickName = x.NickName,
                           Gender = x.Gender,
                           Email = x.Email,
                           Birth = x.Birth,
                           Phone = x.Phone,
                           Level = x.Level,
                           Exp = x.Exp,
                           Point = x.Point,
                           ACHVID = x.ACHVID
                       };
            BindingSource BSMem = new BindingSource();
            BSMem.DataSource = NMem.ToList();
            return BSMem;
        }
        internal BindingSource ConditionOfMember(List<string> Comvle,string Condition,string userValue)
        {
            if (ComText==null)
            {
                ComText = Comvle;
                for (int i = 0; i < ComText.Count; i++)
                {
                    _DIC_AnyTypeForQuery.Add(ComText[i], $"M{i}");
                }
            }
            if (_DIC_AnyTypeForQuery.ContainsKey(Condition))
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
            var NMem = from x in Member
                       select new
                       {
                           MemberID = x.MemberID,
                           Account = x.Account,
                           Password = x.Password,
                           MemberPIC = x.MemberPIC,
                           NickName = x.NickName,
                           Gender = x.Gender,
                           Email = x.Email,
                           Birth = x.Birth,
                           Phone = x.Phone,
                           Level = x.Level,
                           Exp = x.Exp,
                           Point = x.Point,
                           ACHVID = x.ACHVID
                       };
            BindingSource BSMem = new BindingSource();
            BSMem.DataSource = NMem.ToList();
            return BSMem;
        }
        
    }
}
