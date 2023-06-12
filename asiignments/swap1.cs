using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asiignments
{
    internal class swap1
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Enter two numbers");
            Console.WriteLine("Before swap");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine("after swap " + (a, b));

        }
    }
}
