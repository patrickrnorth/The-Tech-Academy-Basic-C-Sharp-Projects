﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment166
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: ");
            string userInput = Console.ReadLine();
            int intOne = Convert.ToInt32(userInput);
            Console.WriteLine("Please enter a second integer: ");
            string userInput2 = Console.ReadLine();
            int intTwo = Convert.ToInt32(userInput2);

            Console.WriteLine(Class1.MyMethod(intOne, intTwo));
            Console.ReadLine();
        }
    }
}
