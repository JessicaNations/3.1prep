using System;                                              
using System.Collections.Generic;                              
using System.Text;                                                                
namespace CirleArea
{
    class Program
    {
        public static void Main(string[] args)
        {
            int radius;
            double area;
            string input;

            Console.WriteLine("Enter a radius:");
            input = Console.ReadLine();
            radius = Convert.ToInt32.(Console.ReadLine());

            area = (3.14) * radius * radius;
            Console.WriteLine("The area of a circle with radius " + radius + " is: " + area);
            Console.ReadLine();
        }
    }
}