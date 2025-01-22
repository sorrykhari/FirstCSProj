/* Practice section
Console.WriteLine("Enter the number of the month you were born (1-12): ");

int month = int.Parse(Console.ReadLine());

switch (month)
{
    case 1:
        Console.WriteLine("January");
        break;
    case 2:
        Console.WriteLine("Febraury");
        break;
    case 3:
        Console.WriteLine("March");
        break;
    case 4:
        Console.WriteLine("April");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    case 6:
        Console.WriteLine("June");
        break;
    case 7:
        Console.WriteLine("July");
        break;
    case 8:
        Console.WriteLine("August");
        break;
    case 9:
        Console.WriteLine("September");
        break;
    case 10:
        Console.WriteLine("October");
        break;
    case 11:
        Console.WriteLine("November");
        break;
    case 12:
        Console.WriteLine("December");
        break;
    default:
        Console.WriteLine("Month not valid");
        break;
}

Console.WriteLine("Enter a number 1-500");
int num = int.Parse(Console.ReadLine());

while (num < 1 || num > 500)
{
    if (num < 1)
    {
        Console.WriteLine("Number too low, try again: ");
        num = int.Parse(Console.ReadLine());
    }
    else if (num > 500)
    {
        Console.WriteLine("Number too high, try again: ");
        num = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine($"You picked: {num}");

string[] jacksonFive = {"Michael", "Jackie", "Tito", "Marlin", "Jermaine"};

for (int i = 0; i < jacksonFive.Length; i++)
{
    Console.WriteLine(jacksonFive[i]);
}

int AddTwoNumbers(int a, int b)
{
    return a + b;
}

int nuuum = AddTwoNumbers(1, 2);

Console.WriteLine(nuuum);
*/

int amount = 6500;

int months = 12;

int yearlyWage = CalculateYearlyWage(amount, months);

Console.WriteLine($"Yearly wage: {yearlyWage}");

static int CalculateYearlyWage(int monthlyWage, int numbersOfMonthsWorked)
{
    //Console.WriteLine($"Yearly wage: {monthlyWage * numbersOfMonthsWorked}");
    return monthlyWage * numbersOfMonthsWorked;
}

