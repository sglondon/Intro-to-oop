using IntroToOOP;
using System;

namespace Intro_to_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat Class

            Cat firstCat = new Cat();
            firstCat.Name = "Mr.Fuzzy";

            Cat secondCat = new Cat("Midnight", 14, "black");

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);

            firstCat.Eat();

            secondCat.Meow();

            firstCat.HairLength = "nice and short";
            secondCat.HairLength = "too long";

            Console.WriteLine(firstCat.Hairball());
            Console.WriteLine(secondCat.Hairball());

            Cat thirdCat = new Cat(1, true);


            //Dog Class

            Dog secondDog = new Dog("long", 3.5, 25, 10.5);

            secondDog.Run();

            secondDog.Height();

            secondDog.HairLength();

            secondDog.Weight();

            //SuperHero Class

            SuperHero firstHero = new SuperHero("Superman", true, "Male", "Faster than a locomotive", "kryptonite");
                        
            SuperHero secondHero = new SuperHero("Wonderwoman", true, "Female", "deflecting bullets", "pasta" );

            Console.WriteLine();
            Console.WriteLine();

            firstHero.Health();
            secondHero.Health();


            //firstCat.HairLength = "nice and short";
            //secondCat.HairLength = "too long";

            //Console.WriteLine(firstCat.Hairball());
            //Console.WriteLine(secondCat.Hairball());

            firstHero.HasCape = true;
            secondHero.HasCape = false;


            Console.WriteLine(firstHero.NeedEnergyBoost());
            Console.WriteLine(secondHero.NeedEnergyBoost());


        }
    }
}
