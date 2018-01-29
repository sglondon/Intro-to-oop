using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToOOP
{
    class SuperHero
    {
        //STATES
        //these are the fields
        
        private string name;
        private bool hasCape  = false;
        private string gender;
        private string superPower;
        private string weakness;

        // PROPERTIES
        //these are the properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }

        public string Gender
        {
            get { return this.gender; }
            set { this.name = gender; }
        }

        public string SuperPower
        {
            get { return this.superPower; }
            set { this.superPower = value; }
        }

        public string Weakness
        {
            get { return this.weakness; }
            set { this.weakness = value; }
        }

        //Behavior
        //this is the Default constructor
        //takes no parameters(nothing in parentheses)

        public SuperHero()
        {
            
            
        }
        //This is another constructor called?
        public SuperHero(string name, bool hasCape, string gender, string superPower, string weakness) //refers to parameter
        {
            this.name = name;  //refers to namefield in class
            this.hasCape = hasCape;
            this.gender = gender;
            this.superPower = superPower;
            this.weakness = weakness;
        }

        //This method sets the value of superpower based on whether weakness = kryptonite
        
        public void Health()
        {
            if (weakness == "kryptonite") 
            {
                superPower = " My Strength is gone, I've been exposed to " + weakness +  "!";
            }
            else
            {
                superPower = "I'm feeling strong today!" + weakness + " makes me healthy!";
            }
            Console.WriteLine(name + " says " + superPower);
        }

        //This method returns a value for hasCape to display a message about energy level
        public string NeedEnergyBoost()
        {
            if (hasCape == false)
            {
                return (this.name + " says, I need my cape for an energy boost!");
            }
            else
            {
                return (this.name + " says, I got an energy boost when I put my cape on!");
            }

        }

    }
}
