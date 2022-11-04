using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance   //Elin Linderholm SUT22
{
    internal class Owls : BirdofPrey  //ärver klassen Rovfågel
    {
        public Owls(): this(0,"No animal", " No name", 00, 0, "No country")  //defaultvärden
        {

        }
        public Owls (float wingspan, string kindofAnimal, string name, int age, float weight, string origin)
            : base (wingspan, kindofAnimal, name, age, weight, origin)
        {

        }

        public override void makeSound()  //delad metod med Rovfågel, polymorphism
        {
            Console.WriteLine("The {0} hoots!", _kindofAnimal);
        }
    }
}
