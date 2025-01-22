using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSProj
{
    internal class Utilities
    {
        public static int CalculateYearlyWage(int monthlyWage, int numbersOfMonthsWorked)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage * numbersOfMonthsWorked}");
            if (numbersOfMonthsWorked == 12)
            {
                return monthlyWage * (numbersOfMonthsWorked + 1);
            }

            return monthlyWage * numbersOfMonthsWorked;
        }

    }
}
