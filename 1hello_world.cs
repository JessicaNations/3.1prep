/* Input/output: Modify your HelloWorld program to 
prompt the user for their name, and greet them by name.  */
using System;
using System.Collections.Generic;
using System.Linq;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What's your name?");
            str input = Console.ReadLine();
            Console.WriteLine($"Hello, {input}!");
            Console.ReadLine();
        }
    }
}