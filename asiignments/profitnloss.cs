using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# Sharp program to calculate profit and loss on a transaction

namespace asiignments
{
    internal class profitnloss
    {
        static void Main(string[] args)
        {
            Double profit, loss,cp,sp;

            Console.WriteLine("Enter cost price and selling price =");
            cp = Convert.ToDouble(Console.ReadLine());
            sp = Convert.ToDouble(Console.ReadLine());

            profit = sp - cp;
            Console.WriteLine("The profit is ="+profit);

            loss = cp - sp;
            Console.WriteLine("The loss is ="+loss);
        }
    }
}
