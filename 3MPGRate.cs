 /* Numeric types: Write a program that asks a user for the 
 number of miles they have driven and the amount of gas they've 
 consumed (in gallons), and print their miles-per-gallon.   */
 
 using System;                                                
 using System.Collections.Generic;                              
 using System.Text;                                                                
 namespace MPGRate
{
    class Program
    {
        public static void Main(string[] args)
        {
            int miles;                                                                                                                            int gallons;
            decimal rate;
            string input;

            Console.WriteLine("Miles driven:");
            input = Console.ReadLine();
            miles = int.(Console.ReadLine());
            Console.WriteLine("Gas consumed (in gallons):");
            input = Console.ReadLine();
            gallons = int.(Console.ReadLine());
            rate = miles/gallons;
            Console.WriteLine("The miles-per-gallon rate is: {0} ", rate);
            Console.ReadLine();
        }
    }
}  