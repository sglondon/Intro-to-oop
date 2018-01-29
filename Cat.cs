using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToOOP
{
    class Cat
{
    //STATES
    //fields
    //I need States
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;
        private string hairLength;
       
        // PROPERTIES
        public string Name
        {
            get { return this.name; }
            set { this.name = value; } 
        }


        public string HairLength
        {
            get {return this.hairLength;}
            set { this.hairLength = value; }
        }


    //I need behavoirs
    //always methods
    //constructors
    public Cat()
    {
        //default constructor
        //takes no parameters(nothing in parentheses)
    }

    public Cat(string name, int age, string furColor) //refers to parameter
        {
            this.name = name;  //refers to namefield in class
            this.age = age;
            this.furColor = furColor;
        }

    public Cat(int age, bool isHungry)
        {
            this.age = age;
            this.isHungry = isHungry;
        }


    public void Eat()
        {
            if (isHungry) //if it's set to true
            {
                isHungry = false;  //changes to false
            }

            Console.WriteLine("Is the cat hungry? " + isHungry);
        }

        public void Meow()
        {
            Console.WriteLine("\a");
        }

        public string Hairball()
        {
            if (hairLength == "too long")
            {
                return (this.name + " has a hairball.");
            }
            else
            {
                return (this.name + " is nicely groomed.");
            }

        }




}
}

