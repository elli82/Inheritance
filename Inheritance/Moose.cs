using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance  //Elin Linderholm SUT22
{
    internal class Moose : Animals   //ärver klassen Animals
    {
        public int _numberofPoints;

        
        public Moose():this(0,"No animal", " No name", 00, 0, "No country")  // defaultvärden
        {

        }
        public Moose (int numberofPoints, string kindofAnimal, string name, int age, float weight, string origin)
            : base (kindofAnimal, name,age, weight,origin)    //eftersom inte constructors ärvs används base keyword
        {
            _numberofPoints = numberofPoints;
        }
        public void Looks()   //metod som säger hur många horn älgen har
        {
            Console.WriteLine("This moose has {} points in its antler.", _numberofPoints);
        }
        public void makeSound() //metod för hur älgen låter
        {
            Console.WriteLine("The {0} bellows.", _kindofAnimal);
        }
    }
}
