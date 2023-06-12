using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to input electricity consumption unit and calculate total electricity bill according to the given condition:
//For first 50 units Rs. 0.50/unit
//For next 100 units Rs. 0.75/unit
//For next 100 units Rs. 1.20/unit
//For unit above 250 Rs. 1.50/unit An
//additional surcharge of 20% is added to the bill 

namespace asiignments
{
    internal class electricitybill
    {
        static void Main(string[] args)
        {
            int unit;
            double amount, total_amount, surcharge;

            Console.WriteLine("Enter unit consumption =");
			unit = Convert.ToInt32(Console.ReadLine());

			if (unit <= 50)
			{
				amount = unit * 0.50;
			}
			else if (unit <= 150)
			{
				amount = unit * 0.75;
			}
			else if (unit <= 250)
			{
				amount = unit * 1.20;
			}
			else
			{
				amount = unit * 1.50;
			}

			surcharge = amount * 0.20;
			total_amount = amount + surcharge;

            Console.WriteLine(total_amount);
		}
    }
}
