using System;

namespace FirstCSProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Human jackie = new Human("Jackie", 25);
            jackie.Eat();

            Human tito = new Human("Tito", 20);
            tito.Sleep();

            Human jermaine = new Human("Jermaine", 17);
            jermaine.Eat();
            jermaine.Sleep();

            Human marlon = new Human("Marlon", 15);
            marlopn.sleep;

            Ninja michael = new Ninja("Michael", "Spin-Kick", "Kunai", 5);
            michael.Eat();
            michael.UseSkill();

            Human.HowManyPeople();
        }
    }
}