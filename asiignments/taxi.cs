using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Taxi.Starting fee: 0.70 EUR.Day rate: 0.79 EUR / km.Night rate: 0.90 EUR / km.
//Bus.Day / Night rate: 0.09 EUR / km.Can be used for distances of minimum 20 km.
//Train. Day / Night rate: 0.06 EUR / km.Can be used for distances of minimum 100 km.
//Write a program that reads the number of kilometers n and period of the day (day or night)
//and calculates the fare amount

namespace asiignments
{
    internal class taxi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. taxi");
            Console.WriteLine("2. bus");
            Console.WriteLine("3. train");

            Console.WriteLine("Select a option=");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the kilometer");
            int km = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a time day or night =");
            char time = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case 1:
                    if (time=='d')
                    {
                        Console.WriteLine("Available");
                        double charges = (km * 0.79)+0.70;

                        Console.WriteLine("the charges for day =" + charges);
                    }
                    else if(time=='n')
                    {
                        double charges = (km * 0.90)+0.70;
                        Console.WriteLine("The charges for day is ="+charges);
                    }
                    else
                    {
                        Console.WriteLine("Not available");
                    }
                    break;

                case 2:
                    if (km >= 20 && time=='d')
                    {
                        Console.WriteLine("Available");
                        double rate = km * 0.09;
                        Console.WriteLine("the charges for day =" + rate);
                    }
                    else if (km >= 20 && time=='n')
                    {
                        Console.WriteLine("Available");
                        double rate = km * 0.09;
                        Console.WriteLine("The charges for night ="+rate);
                    }
                    else
                    {
                        Console.WriteLine("Not available");
                    }
                    break;

                case 3:
                    if (km >= 100 && time == 'd')
                    {
                        Console.WriteLine("Available");
                        double rate = km * 6;
                        Console.WriteLine("the charges for day =" + rate);
                    }
                    else if (km >= 100 && time == 'n')
                    {
                        Console.WriteLine("Available");
                        double rate = km * 6;
                        Console.WriteLine("The charges for night =" + rate);
                    }
                    else
                    {
                        Console.WriteLine("Not available");
                    }

                    break;

                default:
                    Console.WriteLine("no option");
                    break;
            }
        }
    }
}
