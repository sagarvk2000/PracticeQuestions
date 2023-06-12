using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to input any character and check whether it is alphabet, digit or special character 

namespace asiignments
{
    internal class ifelsecheck
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any character ");
            

            ch = Convert.ToChar(Console.ReadLine());
            

            if(ch>='a' && ch <= 'z')
            {
                Console.WriteLine("alphabet");
            }
            else if (ch>='0' && ch<='9'){
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("special character");
            }
        }
    }
}
