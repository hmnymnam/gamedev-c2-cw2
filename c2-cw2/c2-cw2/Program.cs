using System;

namespace c2_cw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string characterName = "hero";
            double characterSpeed = 3.3;
            int characterAge = 30;
            int characterHeight = 170;
            string superPower1 = "night vision";

            string superPower2 = "self healing";
            Console.WriteLine("my name is {0}, my super powers are {1} and {2} , my age is {3} and my speed is {4}", characterName, superPower1, superPower2, characterAge, characterSpeed);

            string heroName = "hero2";
            int heroAge = 40;
            string superPower3 = "lazer gun";
            String superPower4 = "transforming into a beast";
            int heroHeight = 160;
            int ageDifference = heroAge - characterAge;
            Console.WriteLine(ageDifference);
            
            if (characterHeight > heroHeight)
                Console.WriteLine("hero is taller");
            else if (heroHeight > characterHeight)
                Console.WriteLine("hero2 is taller");
            else
                Console.WriteLine("Neither is taller");
        }
    }
}
                        
