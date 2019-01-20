﻿/*
  Author: Peter Millet
  Date: 01/19/2019
  Comments: A program to show Iterative Statement
*/

using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer value between 1 and 100");

            try
            {
                string userinput = Console.ReadLine();

                int userint = int.Parse(userinput);

                // This code converts what the user entere into an int value

                if ((userint >= 1) && (userint <= 100))
                {
                    Console.WriteLine("A while loop will execute now.");
                    Console.WriteLine("You have entered " + userint.ToString());

                    while (userint > 0)
                    {
                        Console.WriteLine("This is the current integer value in the loop " + userint.ToString());
                        userint--;
                    }

                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Between 1 and 100 please");
                    Console.WriteLine("The program will now close");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value");
                Console.WriteLine("The program will now close.");
                Console.ReadKey(true);
            }
        }
    }
}
