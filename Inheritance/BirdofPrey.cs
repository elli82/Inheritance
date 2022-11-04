using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance   //Elin Linderholm SUT22
{
    internal class BirdofPrey : Animals  //ärver från Animals
    {
        public float _wingspan;

        public BirdofPrey(): this(0,"No animal", " No name", 00, 0, "No country")  //defaultvärden
        {

        }

        public BirdofPrey(float wingspan,string kindofAnimal, string name, int age, float weight, string origin)
            : base(kindofAnimal, name, age, weight, origin)  //base keyword
        {
            _wingspan = wingspan;
        }

        public void howLargeisBird()  //metod för att skriva ut hur brett vingspann fågeln har
        {
            Console.WriteLine("This {0} has {1} m between its wings.",_kindofAnimal, _wingspan);                
        }
        public virtual void makeSound() //hur fågeln låter
        {
            Console.WriteLine("The {0} calls.", _kindofAnimal);
        }
    }
}
