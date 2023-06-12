using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to find maximum between three numbers (using logical operator)

namespace asiignments
{
    internal class maxno
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.WriteLine("Enter three number =");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());


            if (a>b && a>c )
            {
                Console.WriteLine("a is max " +a);
            }
            else if(b>c)
            {
                Console.WriteLine("b is max " +b);
            }
            else
            {
                Console.WriteLine("c is max "+c);
            }
        }
    }
}
