using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to enter number between 1to 5 and print it in word

namespace asiignments
{
    internal class switchcase3
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number =");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("One");
                    break;

                case 2:
                    Console.WriteLine("Two");
                    break;

                case 3:
                    Console.WriteLine("Three");
                    break;

                case 4:
                    Console.WriteLine("Four");
                    break;

                case 5:
                    Console.WriteLine("Five");
                    break;

                default:
                    Console.WriteLine("Invalid number...!");
                    break;
            }

        }
    }
}
