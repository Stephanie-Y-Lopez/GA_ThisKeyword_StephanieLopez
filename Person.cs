using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_ThisKeyword_StephanieLopez
{
    internal class Person
    {
        //Fields
        private string name;
        private int age;

        //Constructor using "this" to differ fields from parameters
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //Method to display person's details
        public void Display()
        {
            Console.WriteLine($"Name:{this.name}, Age:{this.age}");
        }

        //Overload constructor
        public Person(string name) : this(name, 0) //Uses the main constructor
        {
        }

        //This method will update person's age
        public void SetAge(int age)
        {
            this.age = age; //"this" is used to clarify that we are assigning it to the instance field
        }
    }
}
