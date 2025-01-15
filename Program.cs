// First C# Project !!!
/*
double ratePerHour = 12.34;
int numberOfHoursWorked = 165;
int bonus = 100;

double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;
Console.WriteLine(currentMonthWage);

ratePerHour += 3;
Console.WriteLine(ratePerHour);

if (currentMonthWage > 2000)
{
    Console.WriteLine("You are a good worker");
}
else
{
    Console.WriteLine("You are a bad worker");
}

int numberOfEmployees = 15;
numberOfEmployees--;

bool a;
int b;

int intMaxValue =int.MaxValue;
int intMinValue = int.MinValue;

char userSelection = 'a'; // Chars use single quotes '' instead of double quotes like strings
char upperSelection = char.ToUpper(userSelection);
*/

DateTime hireDate = new DateTime(2022, 3, 28, 14, 30, 0);

DateTime startDate = hireDate.AddDays(15);

Console.WriteLine(startDate.ToLongDateString());
Console.WriteLine(startDate.ToShortDateString());
Console.WriteLine(startDate.IsDaylightSavingTime());

TimeSpan workTime = new TimeSpan(8, 35, 0);
DateTime endHour = startDate.Add(workTime);
DateTime exitDate = new DateTime(2025, 12, 11);

Console.WriteLine(endHour);

 