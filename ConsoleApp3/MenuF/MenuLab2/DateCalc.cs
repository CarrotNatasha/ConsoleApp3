using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MenuF.RecursionDate
{
    public static class RecursionCalc
    {
        public static uint RecursionAkermann(uint uiM, uint uiN)
        {
            if (uiM < 62)
            {
                if (uiM == 0)
                {
                    return uiN + 1;
                }
                else
                {
                    if (uiM != 0 && uiN == 0)
                    {
                        return RecursionAkermann(uiM - 1, uiN);
                    }
                    else
                    {
                        return RecursionAkermann(uiM - 1, RecursionAkermann(uiM, uiN - 1));
                    }
                }
            }
            else
            {
                throw new Exception("M is bigger than MAX ammount!");
            }
        }
        public static uint DateWriteiM(DateTime dtDateStart1, DateTime dtDateEnd1, DateTime dtDateStart2, DateTime dtDateEnd2)
        {

            uint uiM = 0;
            /* if (dtDateStart1 < dtDateStart2)
            { */
            if (dtDateEnd1 < dtDateStart2)
            {
                throw new Exception("Second date should start earlier than first ends");
            }
            else
            {
                while (dtDateStart2 <= dtDateEnd1)
                {
                    uiM++;
                    dtDateStart2 = dtDateStart2.AddDays(1);
                }
            }
                /*else
            {
                /* if (dtDateEnd2 < dtDateStart1)
                {
                    throw new Exception("First date should end later than first starts");
                }
                else
                { 
                while (dtDateStart1 <= dtDateEnd2)
                {
                    uiM++;
                    dtDateStart1 = dtDateStart1.AddDays(1);
                }
            } */
            return uiM;
        }
    }
}
