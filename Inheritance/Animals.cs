using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance    //Elin Linderholm SUT22
{
    public class Animals  //basklass
    {
        public string _kindofAnimal;
        public string _name;
        public int _age;
        public float _weight;
        public string _origin;
        private Animals animals;
        
        public Animals(string kindofAnimal, string name, int age, float weight, string origin)  //constructor
        {
            _kindofAnimal = kindofAnimal;
            _name = name;
            _age = age;
            _weight = weight;
            _origin = origin;
        }

        public Animals(Animals animals)
        {
            this.animals = animals;
        }

        public void PrintInfo()  //metod som skriver ut info om djuren
        {
            Console.WriteLine("This is a {0} with the name {1}. It is {2} years old and weighs {3} kg." +
                " It comes from {4}.", _kindofAnimal, _name, _age, _weight, _origin);
        }
        public void makeWalk()  //metod för att djuren rör på sig
        {
            Console.WriteLine("The {0} is walking.", _kindofAnimal);
        }
        public void makeEat() //metod för att djuren äter
        {
            Console.WriteLine("The {0} is eating.", _kindofAnimal);
        }

    }
}
