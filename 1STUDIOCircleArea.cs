using System;
using System.Collections.Generic;
using System.Text;
namespace CirleArea
{
    class Program
    {
        public static void Main(string[] args)
        {
            double radius;
            double area;
            string input;

            Console.WriteLine("Enter a radius:");
            input = Console.ReadLine();
            radius = double Convert.parse(input);

            area = Math.PI * radius * radius;
            Console.WriteLine($"The area of a circle with radius {radius} is: {area}");
            Console.ReadLine();
        }
    }
}
