/*
 Author: Katera Jefferson
 Date: 9/15/2020
 */


using System;

namespace I_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer value between 1 and 25 to execute an iterative statement: ");
            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);
                if ((value_of_input > 0) && (value_of_input <= 5))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + "times.");
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered" + value_of_input.ToString() + "This is the current integer value in the loop: " + value_of_input.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
            }
        }
    }
}
