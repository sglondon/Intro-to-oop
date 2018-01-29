using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToOOP
{
    class Cat
{
    //fields
    //I need States
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;
       

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }





    //I need behavoirs
    //always methods
    //constructors
    public Cat()
    {
        //default constructor
        //takes no parameters(nothing in parentheses)
    }

    public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }
    public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
            }

            Console.WriteLine("Is the cat hungry? " + isHungry);
        }
}
}

