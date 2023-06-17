using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asiignments
{
    internal class uplowcase
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter a chracter =");
            ch = Convert.ToChar(Console.ReadLine());    

            if(ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("It is a lower case");
            }
            else if (ch >= 'A' && ch <= 'Z')    
            {
                Console.WriteLine("It is upper case");
            }
            else
            {
                Console.WriteLine("This is not alphabet");
            }
        }
    }
}
