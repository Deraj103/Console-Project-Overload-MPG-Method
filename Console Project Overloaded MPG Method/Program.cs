using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_Project_Overloaded_MPG_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int miles1;
            int gallons1;
            double miles2;
            double gallons2;

            WriteLine("Ch 3 Console Project Overloaded MPG Method by Jared Tims\n");

            //ask user for interger for miles and gallons
            Write("Enter an interger for miles: ");
            miles1 = Convert.ToInt32(ReadLine());
            Write("Enter an integer for gallons: ");
            gallons1 = Convert.ToInt32(ReadLine());

            WriteLine($"Integer MPG = {calcMPG(miles1, gallons1)}\n");

            //ask user for double for miles and gallons
            Write("Enter a double for miles: ");
            miles2 = Convert.ToDouble(ReadLine());
            Write("Enter a double for gallons: ");
            gallons2 = Convert.ToDouble(ReadLine());

            WriteLine($"Double MPG = {calcMPG(miles2, gallons2)}");


            WriteLine("\nPress any key to continue.");
            ReadKey();
        }

        static int calcMPG(int miles1, int gallons1)
        {
            int mpg1 = miles1 / gallons1;

            return mpg1;
        }

        static double calcMPG(double miles2, double gallons2)
        {
            double mpg2 = miles2 / gallons2;

            return mpg2;
        }
    }
}
