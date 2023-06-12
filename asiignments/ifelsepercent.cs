using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Accept marks of 3 subjects physics , chemistry, maths out of 100. Calculate percentage.
//Display grade as below.
//Percentage > 80% - Grade A
//Percentage > 70% - Grade B
//Percentage > 60% - Grade C
//Percentage < 60% - Grade D

namespace asiignments
{
    internal class ifelsepercent
    {
        static void Main(string[] args)
        {
            int physics, chemistry, maths;
            double percent, total;
            Console.WriteLine("Enter three subjects marks =");
            physics = Convert.ToInt32(Console.ReadLine());
            chemistry = Convert.ToInt32(Console.ReadLine());
            maths = Convert.ToInt32(Console.ReadLine());

            total = physics + chemistry + maths;
            Console.WriteLine("total =" + total);

            percent = (double)total / 3;
            Console.WriteLine("percentage is =" + percent);

            if (percent > 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (percent > 60)
            {
                Console.WriteLine("Grade B");
            }
            else if (percent < 60)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("fail ");
            }
        }
    }
}
