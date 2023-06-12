using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//WAP to accept a character from user & check whether it is vowel or not
namespace asiignments
{
    internal class vowel
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter a alphabet=");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("It is a vowel " + ch);
            }
            else if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("It is consonant " + ch);
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
    }
}
