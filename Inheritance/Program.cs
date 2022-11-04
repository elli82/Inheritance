using System;

namespace Inheritance  // Elin Linderholm SUT22
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Moose moose1 = new Moose(6,"moose", "Hälge", 10, 465.60f, "Sweden");            
            moose1.PrintInfo();
            moose1.makeSound();
            Console.WriteLine("---------");

            Wolfs wolf1 = new Wolfs("grey", "wolf", "Zeke", 5, 32.5f, "Russia");
            wolf1.makeEat();
            wolf1.LookofFur();
            wolf1.makeSound();
            Console.WriteLine("---------");

            BirdofPrey bird1 = new BirdofPrey(1, "hawk", "Heidi", 1, 3.5f, "Sweden");
            bird1.howLargeisBird();
            bird1.makeSound();
            Console.WriteLine("---------");

            Eagles bird2 = new Eagles (4,3, "eagle", "Jay", 4, 6.6f, "Great Britain");
            bird2.Vision();
            bird2.makeSound();
            bird2.makeFly();
            Console.WriteLine("---------");

            Owls bird3 = new Owls(3, "owl", "Uwe", 12, 6, "Germany");
            bird3.PrintInfo();
            bird3.makeSound();
            Console.WriteLine("---------");



        }
    }
}
