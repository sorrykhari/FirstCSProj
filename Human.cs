using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSProj
{
    public class Human
    {
        public string name;
        public int age;
        static int numberOfPeople;

        // Constructors
        public Human(String name)
        {
            this.name = name;
            numberOfPeople++;
        }
        public Human(String name, int age)
        {
            this.name = name;
            this.age = age;
            numberOfPeople++;
        }
        // Methods
        public void Eat()
        {
            Console.WriteLine($"{name} is eating.");
        }
        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping.");
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

    public class Ninja : Human
    {
        public string skill;
        public string weapon;
        public int level;
        public Ninja(string name, string skill, string weapon, int age, int level) : base(name)
        {
            this.skill = skill;
            this.weapon = weapon;
            this.level = level;
        }

        public void UseSkill()
        {
            if (level > 10)
            {
                Console.WriteLine($"{name} uses {skill} with {weapon} at level {level}.");
            }
            else
            {
                Console.WriteLine($"{name} is not skilled enough to use {skill}. Must be level 10 or higher.");
            }
        }

    }
}
