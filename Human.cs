using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSProj
{
    public class Human
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        static int numberOfPeople;

        // Constructors
        public Human(String name)
        {
            this.Name = name;
            numberOfPeople++;
        }
        public Human(String name, int age)
        {
            this.Name = name;
            this.Age = age;
            numberOfPeople++;
        }
        // Methods
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
        // Static Method
        public static void HowManyPeople()
        {
            if (numberOfPeople > 1)
            {
                Console.WriteLine($"There are {numberOfPeople} people.");
            }
            else
            {
                Console.WriteLine("There is 1 person.");
            }
            
        }

    }

}
