using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asiignments
{
    internal class swap2
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two numbers =");
            Console.WriteLine("before swap ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("after swap " + (a, b));
        }
    }
}
