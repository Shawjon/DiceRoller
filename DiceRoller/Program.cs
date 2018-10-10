using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yesNo = true;
            int x;
            long output1;
            long output2;
            Console.Write("Welcome to the Grand Circus Casino! Roll the dice? (y/n):");
            string entry1 = Console.ReadLine();
            while (entry1.ToLower() != "n" || entry1.ToLower() != "y" || entry1.ToLower() != "no" || entry1.ToLower() != "yes")
            {
                if (entry1.ToLower() == "n" || entry1.ToLower() == "no")
                {
                    yesNo = false;
                    Console.WriteLine("Thank you for playing?");
                    break;
                }
                else if (entry1.ToLower() == "y" || entry1.ToLower() == "yes")
                {
                    yesNo = true;
                    ///entry = "y";
                    break;
                }
                else
                {
                    Console.Write("That is not a valid answer, Continue? (y/n): ");
                    entry1 = Console.ReadLine();
                }
            }


            Console.WriteLine("");
            while (yesNo == true)
            {
                try
                {
                    Console.Write("How many sides should each dice have? ");
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x < 1)
                    {
                        Console.WriteLine("That is not a valid option");
                        continue;
                    }

                    Random rnd = new Random();
                    output1 = GetRoll(x, rnd);
                    output2 = GetRoll(x, rnd);


                    Console.WriteLine("Roll1:");
                    Console.WriteLine(output1);
                    Console.WriteLine(output2);
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid inut");
                }

                Console.Write("Roll again? (y/n): ");
                string entry = Console.ReadLine();
                while (entry.ToLower() != "n" || entry.ToLower() != "y" || entry.ToLower() != "no" || entry.ToLower() != "yes")
                {
                    if (entry.ToLower() == "n" || entry.ToLower() == "no")
                    {
                        yesNo = false;
                        Console.Write("Thank you for playing! Have a good day.");
                        break;
                    }
                    else if (entry.ToLower() == "y" || entry.ToLower() == "yes")
                    {
                        yesNo = true;
                        ///entry = "y";
                        break;
                    }
                    else
                    {
                        Console.Write("That is not a valid answer, Continue? (y/n): ");
                        entry = Console.ReadLine();
                    }
                }
            }
        }
        private static long GetRoll(int x, Random rnd)
        {
            ///Random rnd = new Random();
            int roll = rnd.Next(1, (x + 1));
            return roll;
        }
        
    }

}
