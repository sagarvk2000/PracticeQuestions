using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 //WAP in    using switch case for following: Area of a circle
 //Area of a square Area of a right angled triangle
 //Area of a rectangle Circumference of a circle Perimeter of a square
 //Accept inputs like radius, side, etc through keyboard. 
 //Menu driven program using switch case:

namespace asiignments
{
    internal class switchcase4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Area of circle and Circumference of a circle ");
            Console.WriteLine("2. Area of square and  Perimeter of a square");
            Console.WriteLine("3. Area of right angled triangle");
            Console.WriteLine("4. Area of rectangle");

            Console.WriteLine("Enter a number =");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    double area, r,pi=3.14,circum;                    
                    Console.WriteLine("Enter a radius =");
                    r = Convert.ToDouble(Console.ReadLine());
                    area = pi * r * r;
                    Console.WriteLine("The area of Circle is ="+area);

                    circum = 2 * pi * r;
                    Console.WriteLine("\n The circumference of circle is ="+circum);
                    break;

                case 2:
                    int a, area1, peri;
                    Console.WriteLine("Enter a side =");
                    a = Convert.ToInt32(Console.ReadLine());

                    area1 = a * a;
                    Console.WriteLine("The area of square is ="+area1);

                    peri = 4 * a;
                    Console.WriteLine("The perimeter of square ="+peri);
                    break;

                case 3:
                    double area2, x, y;
                    Console.WriteLine("Enter both side of triangle =");
                    x = Convert.ToDouble(Console.ReadLine());
                    y = Convert.ToDouble(Console.ReadLine());

                    area2 = (x * y) / 2;
                    Console.WriteLine("The area of right angled triangle =" +area2);
                    break;

                case 4:
                    int l, w,area3;
                    Console.WriteLine("Enter the length and width ");
                    l = Convert.ToInt32(Console.ReadLine());
                    w = Convert.ToInt32(Console.ReadLine());

                    area3 = l * w;
                    Console.WriteLine("The area of triangle is ="+area3);
                    break;


                 default:
                    Console.WriteLine("Invalid number...!");
                    break;
            }
        }
    }
}
