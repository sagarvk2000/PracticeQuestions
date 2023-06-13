using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Depending on age (decimal number and gender (m / f), print a personal title:

//“Mr.” – a man(gender “m”) – 16 or more years old.
//“Master” – a boy (gender “m”) under 16 years.
//“Ms.” – a woman(gender “f”) – 16 or more years old.
//“Miss” – a girl (gender “f”) under 16 years

namespace asiignments
{
    internal class personaltitle
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter a age and gender =");
            age = Convert.ToInt32(Console.ReadLine());
            char gender = Convert.ToChar(Console.ReadLine());

            if(age>=16 && gender == 'm')
            {
                Console.WriteLine("[Mr] a man ");
            }
            else if (age <=16 && gender == 'm')
            {
                Console.WriteLine("[Master] a boy");
            }
            else if (age >=16 && gender == 'f')
            {
                Console.WriteLine("[Ms] a women");
            }
            else
            {
                Console.WriteLine("[miss] a girl");
            }           
        }
    }
}
