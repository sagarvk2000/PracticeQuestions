using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//wap to print 1-7 week days using switch case

namespace asiignments
{
    internal class switchcase2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("1. Sunday");
                    break;

                case 2:
                    Console.WriteLine("2. monday");
                    break;

                case 3:
                    Console.WriteLine("3. Tuesday");
                    break;

                case 4:
                    Console.WriteLine("4. Wedesday");
                    break;

                case 5:
                    Console.WriteLine("5. Thursday");
                    break;

                case 6: 
                    Console.WriteLine("6. Friday");
                    break;

                case 7:
                    Console.WriteLine("7. Saturday");
                    break;

                default:
                    Console.WriteLine("You entered wrong number...!");
                    break;
            }
        }
    }
}
