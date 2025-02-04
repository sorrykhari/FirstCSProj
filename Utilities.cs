using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSProj
{
    internal class Utilities
    { 
        public static void UsingOptionalParameters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOptional(monthlyWage1, months1, 6000);
            Console.WriteLine($"Yearly wage for employee (Alex): {yearlyWageForEmployee1}");
        }

    
        public static int CalculateYearlyWageWithOptional(int monthlyWage, int numbersOfMonthsWorked, int bonus = 0)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage * numbersOfMonthsWorked}");
            if (numbersOfMonthsWorked == 12)
            {
                return monthlyWage * (numbersOfMonthsWorked + 1);
            }

            return monthlyWage * numbersOfMonthsWorked;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numbersOfMonthsWorked)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage * numbersOfMonthsWorked}");

            return monthlyWage * numbersOfMonthsWorked;
        }
        public static int CalculateYearlyWage(int monthlyWage, int numbersOfMonthsWorked, int bonus = 0)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage * numbersOfMonthsWorked}");
            if (numbersOfMonthsWorked == 12)
            {
                return monthlyWage * (numbersOfMonthsWorked + bonus);
            }

            return monthlyWage * numbersOfMonthsWorked + bonus;
        }

    }
}
