using ConsoleApp3.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MenuF.MenuLab2
{
    public static class DateRead
    {
        public static DateTime Write()
        {
            DateTime dtDate = SafeRead.SafeDate("d1st","",null);
            return dtDate;
        }
        public static DateTime WriteEarlier(string sIden, DateTime dtDate1)
        {
            DateTime dtDate2 = SafeRead.SafeDate(sIden,"", new IsEarlierDate(dtDate1));
            return dtDate2;
        }
    }
}
