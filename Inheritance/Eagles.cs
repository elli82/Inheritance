using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance   //Elin Linderholm SUT22
{
    internal class Eagles : BirdofPrey  //ärver Rovfågel
    {
        public int _vision;
        
        public Eagles():this(0,0, "No animal", " No name", 00, 0, "No country")
        {

        }
        public Eagles(int vision,float wingspan, string kindofAnimal, string name, int age, float weight, string origin)
            : base (wingspan, kindofAnimal, name, age, weight, origin)
        {
            _vision = vision;        
        }           
        public void makeFly()  //flyger
        {
            Console.WriteLine("The {0} is flying!", _kindofAnimal);
        }
        public void Vision()  //skriver hur långt örnen kan se
        {
            Console.WriteLine("The {0} can see for {1} km.", _kindofAnimal, _vision);
        }
    }

}
