using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP to accept a number from the user & check number is +ve or -ve or zero.

namespace asiignments
{
    internal class ifelseno
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a number =");
            a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("positive");
            }
            else if(a < 0)
            {
                Console.WriteLine("negative");
            }
            else if(a==0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine(" ");
            }
            
        }
    }
}
