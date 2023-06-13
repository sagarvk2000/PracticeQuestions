using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A bank intends to design a program to display the denomination of an input amount. 
//The available denomination with the bank are of rupees 2000, 500, 200, 100, 50, 20, 10 and 1.

namespace asiignments
{
    internal class switchcase
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter two number =");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Modulus");
            Console.WriteLine("Enter a number to select option =");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1: 
                    int sum = n1+ n2;
                    Console.WriteLine("The addition is "+sum);
                    break;

                case 2:
                    int sub = n1 - n2;
                    Console.WriteLine("The substraction is "+sub);
                    break;

                case 3: 
                    int mul = n1* n2;
                    Console.WriteLine("The multiplication is "+mul);
                    break;

                case 4:
                    double div =(double) n1/ n2;
                    Console.WriteLine("The division is "+div);
                    break;

                case 5:
                    int mod = n1 % n2;
                    Console.WriteLine("The modulus is "+mod);
                    break;

                default:
                    Console.WriteLine("You have entered wrong option...!");
                    break;
            }

        }
    }
}
