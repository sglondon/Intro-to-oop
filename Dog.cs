using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToOOP
{
    class Dog
    {
        private string hairLength;
        private double height;
        private int runningSpeed;
        private double weight;

        // PROPERTIES
        public string Name
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }


        public Dog()
        {
            //default constructor
            //takes no parameters(nothing in parentheses)

        }


        public Dog(string hairLength, double height, int runningSpeed, double weight) //refers to parameter
        {
            this.hairLength = hairLength;  //refers to namefield in class
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        public void Run()
        {
            
            runningSpeed++;

            

            Console.WriteLine("The dog's speed is " + runningSpeed);
        }

        public void Height()
        {
            Console.WriteLine("The dog is " + height + " feet tall.");
        }

        public void HairLength()
        {
            Console.WriteLine("The dog's hair is " + hairLength);
        }

        public void Weight()
        {
            Console.WriteLine("The dog's weight is " + weight);
        }


    }

}

