using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance   //Elin Linderholm SUT22
{
    internal class Wolfs : Animals  //ärver Animals
    {
        public string _colorofFur;

        public Wolfs(): this ("No colour","No animal", " No name", 00, 0, "No country")  //defaultvärden
        {

        }

        public Wolfs(string colorofFur, string kindofAnimal, string name, int age, float weight, string origin) 
            : base (kindofAnimal, name, age, weight, origin)

        {
            _colorofFur = colorofFur;
        }

        public void LookofFur()  //beskriver vargens utseende
        {
            Console.WriteLine("This wolf has {0} and soft fur.", _colorofFur);
        }
        public void makeSound() //såhär låter vargen
        {
            Console.WriteLine("The {0} is howling.", _kindofAnimal);
        }
    }
}
