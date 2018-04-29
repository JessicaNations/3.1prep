/* Input/output: Modify your HelloWorld program to 
prompt the user for their name, and greet them by name.  */
using System;                                              
using System.Collections.Generic;                              
using System.Text;
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input;

            Console.WriteLine("What's your name?");
            input = Console.ReadLine();

            Console.WriteLine("Hello World!" + input);
            Console.ReadLine();
        }
    }
}