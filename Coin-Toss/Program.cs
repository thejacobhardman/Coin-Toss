using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    class Program
    {
        public static bool Flip()
        {
            Random rand = new Random();
            int num = rand.Next(1, 3);

            switch (num)
            {
                case 1:
                    return true;
                case 2:
                    return false;
                default:
                    Console.WriteLine("RAND ERROR");
                    break;
            }

            return true;
        }
        static void Main(string[] args)
        {
            int choice, numOfHeads = 0, numOfTails = 0;

            Console.WriteLine("Welcome to Coin Toss!\n");

            do
            {
                do
                {
                    Console.WriteLine("1. Toss Coin\n2. Exit");
                    Console.Write("Enter Choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice < 0 || choice > 2) { Console.WriteLine("Please enter a valid selection.\n"); }
                } while (choice < 0 || choice > 2);

                if (choice != 2)
                {
                    bool heads = Flip();

                    if (heads == true)
                    {
                        Console.WriteLine("\nHeads!");
                        numOfHeads += 1;
                    }
                    else
                    {
                        Console.WriteLine("\nTails!");
                        numOfTails += 1;
                    }

                    Console.WriteLine("Heads: " + numOfHeads + "  Tails: " + numOfTails + "\n");
                }

            } while (choice != 2);

            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey();
        }
    }
}
