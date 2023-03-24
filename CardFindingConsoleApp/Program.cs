using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFindingConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int chance = 0;
                while (chance < 3)
                {
                    Console.WriteLine("Enter Your Card Number:");
                    string cardNumber = Console.ReadLine();
                    if (cardNumber.StartsWith("1234"))
                    {
                        Console.WriteLine("This is VISA(1234) Card");
                        Console.ReadKey();
                    }
                    else if (cardNumber.StartsWith("9090"))
                    {
                        Console.WriteLine("This is RUPAY(9090) Card");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Card");
                        Console.ReadKey();
                        chance++;
                    }
                    Console.Clear();
                }
                if (chance == 3)
                {
                    break; 
                }
            }

        }
    }
}
