using System;

namespace FirstCSProj
{
    class Program
    {
        static void Main(string[] args)
        {

            //Jackson5Crap();
            //GuessingGame.PlayGame();
            //Animal animal = new Animal();
            //PolyMorphismStuff();
            //InterfacePractice();
            List<string> jacksons = new List<string>();

            jacksons.Add("Jackie");
            jacksons.Add("Tito");
            jacksons.Add("Jermaine");
            jacksons.Add("Marlon");
            jacksons.Add("Michael");
            jacksons.Remove("Jermaine");
            jacksons.Add("Randy");

            jacksons.Insert(2, "Jermaine");
            

            foreach (string jackson in jacksons)
            {
                Console.WriteLine(jackson);
            }

            Console.WriteLine(jacksons.IndexOf("Michael"));

        }

        static void PolymorphismStuff()
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Frog frog = new Frog();

            Animal[] animals = { dog, cat, frog };

            foreach (Animal animal in animals)
            {
                animal.Speak();
            }
        }
        static void ChangeWeapon(Ninja ninja, string weapon)
        {
            ninja.weapon = weapon;
            Console.WriteLine($"{ninja.name} changed weapon to {ninja.weapon}.");
        }

        static void Jackson5Crap()
        {
            Human[] jackson5 = new Human[5];

            Human jackie = new Human("Jackie", 25);
            jackie.Eat();

            Human tito = new Human("Tito", 20);
            tito.Sleep();

            Human jermaine = new Human("Jermaine", 17);
            jermaine.Eat();
            jermaine.Sleep();

            Human marlon = new Human("Marlon", 15);
            marlon.Sleep();

            Ninja michael = new Ninja("Michael", "Spin-Kick", "Kunai",13, 11);
            michael.Eat();
            michael.UseSkill();

            jackson5[0] = jackie;
            jackson5[1] = tito;
            jackson5[2] = jermaine;
            jackson5[3] = marlon;
            jackson5[4] = michael;

            foreach (Human jackson in jackson5)
            {
                Console.WriteLine(jackson);
            }

            ChangeWeapon(michael, "Shuriken");
            michael.UseSkill();
        }
        static void InterfacePractice()
        {
            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();
            hawk.Attack();
            rabbit.Flee();
            fish.Attack();
            fish.Flee();
        }

        class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("The animal says hi.");
            }
        }
        class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Dog barks.");
            }
        }
        class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Cat meows.");
            }
        }
        class Frog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Frog ribbits");
            }
        }

        interface IPrey
        {
            void Flee();
        }
        interface IPredator
        {
            void Attack();
        }
        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away!");
            }
        }
        class Hawk : IPredator
        {
            public void Attack()
            {
                Console.WriteLine("The hawk attacks!");
            }
        }
        class Fish : IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("The fish runs away!");
            }
            public void Attack()
            {
                Console.WriteLine("The fish attacks!");
            }
        }
        
    }
}