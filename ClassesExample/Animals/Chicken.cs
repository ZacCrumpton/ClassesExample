using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animals
{
    class Chicken
    {
        //property
        public string Name { get; set; }

        //field
        private bool _isHungry = true;


        //default container
        //public Chicken() { }

        //constructor
        public Chicken(string name)
        {
            Name = name;
            Console.WriteLine($"{name} got instatiated");
        }

        //method (signature = accessibility modifer -> return type -> Name -> Parameters
        public void Peck(string typeOfFood)
        {
            if (_isHungry)
            {
                Console.WriteLine($"{Name} pecks hungrily at the {typeOfFood}");
                _isHungry = false;
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }

        }

        //method overloading
        public void Peck()
        {
            Peck("Corn");
        }

    }
}
