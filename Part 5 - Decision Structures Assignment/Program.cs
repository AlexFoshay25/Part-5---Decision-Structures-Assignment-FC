using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_Ifs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            string input;
            int age;
            string inp;
            int cat;
            int ran;
            int div;
            string uinp;
            Console.Write("Enter your age: ");
            input = Console.ReadLine();



            if (int.TryParse(input, out age))
            {
                if (age > 60)
                {
                    Console.WriteLine("You're elderly");
                }

                else if (age >= 18)
                {
                    Console.WriteLine("You're an adult");
                }
                else if (age > 12)
                {
                    Console.WriteLine("You're a teen");
                }
                else if (age <= 5)
                {
                    Console.WriteLine("You're a toddler");
                }
                else if (age <= 10)
                {
                    Console.WriteLine("You're a child");
                }
                else if (age <= 12)
                {
                    Console.WriteLine("You're a preteen");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input Press Enter to Close");
            }

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.Write("Enter 1,2,3,4 or 5 for a Category hurricane: ");
            input = Console.ReadLine();
            int.TryParse(input, out cat);


            switch (cat)
            {
                case 1:
                    Console.WriteLine("It's a Category 1 Hurricane!");
                    Console.WriteLine("It's going 84 mph/72 kts/135 kmph");
                    break;
                case 2:
                    Console.WriteLine("It's a Category 2 Hurricane!");
                    Console.WriteLine("It's going 98 mph/85 kts/156 kmph");
                    break;
                case 3:
                    Console.WriteLine("It's a Catehory 3 Hurricane!");
                    Console.WriteLine("It's going 123 mph/106 kts/197 kmph");
                    break;
                case 4:
                    Console.WriteLine("It's a Category 4 Hurricane!");
                    Console.WriteLine("It's going 154 mph/133 kts/247 kmph");
                    break;
                case 5:
                    Console.WriteLine("It's a Category 5 Hurricane!");
                    Console.WriteLine("It's going 437 mph/379 kts/702 kmph");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }


            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            ran = generator.Next(2, 6);

            Console.WriteLine($"Your Random Number is {ran}");

            Console.Write("Enter a number larger than the random number: ");
            uinp = Console.ReadLine();

            if (int.TryParse(uinp, out div))
            {
                if (div % ran == 0)
                {
                    Console.WriteLine($"{div} is divisible by {ran}");
                }
                else if (div < ran)
                {
                    Console.WriteLine($"{div} is smaller than {ran}");
                }
                else if (div % ran != 0)
                {
                    Console.WriteLine($"{div} is not divisible by {ran}");

                }
            }
            else
            {
                Console.WriteLine("-- Invalid Input --");
            }

            Console.WriteLine("Press Enter to Exit");








            Console.ReadLine();





        }
    }
}