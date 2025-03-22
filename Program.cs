using System;

namespace FirstCSProj
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Math
             * 
            // Find hypotenuse
            Console.WriteLine("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine($"The hypotenuse is {c}");
            
            String fullName = "Kai Mobley";
            String phoneNumber = "732-422-3771";
            String userName = "enjeeeeb";
            String firstName = fullName.Substring(0, 3);
            String lastName = fullName.Substring(4);

            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(phoneNumber.Replace("-", " "));
            Console.WriteLine(userName.Length);
            Console.ReadKey();
            

            // If statements
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

             if (age < 0)
            {
                Console.WriteLine("Please enter a valid age.");
            }
             else if (age < 18)
            {
                Console.WriteLine("You're not old enough, sorry.");
            }
             else if (age > 100)
            {
                Console.WriteLine("You're way too old for this unc.");
            }
             else
            {
                Console.WriteLine("Here's your license.");
            }

            Console.ReadKey();
            */
            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("You didn't enter a name.");
            }
            else if (name != "")
            {
                Console.WriteLine($"Hello {name}.");
            }
            else
            {
                Console.WriteLine("Just fuck off mane.");
            }

            Console.ReadKey();
        }
    }
}