/* Numeric types: Write a program to calculate the area of a 
rectangle and print the answer to the console. You should 
prompt the user for the dimensions. (What data types should 
the dimensions be?)    */

using System;

namespace RectArea
{
    class Program
    {
        public static void Main(string[] args)
        {
            decimal width;
            decimal length;
            string input;

            Console.WriteLine("Enter a width:");
            input = Console.ReadLine();
            decimal width = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter a length:");
            input = Console.ReadLine();
            decimal length = decimal.Parse(Console.ReadLine());
            decimal area = width * length;
            Console.WriteLine("The area of a circle with width " + width + " and length " + length + " is: {0}", area);
            Console.ReadLine();
        }
    }
}