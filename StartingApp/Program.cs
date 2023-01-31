// See https://aka.ms/new-console-template for more information
// ask a user to input a string and count the number of times each character appears in the string
//Ask the user if they are sure this is the string they want to use
//if the user says yes, then count the number of times each character appears in the string
//if the user says no, then ask them to input a new string

using System;
using System.Collections.Generic;

namespace StartingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string input = Console.ReadLine();
            Console.WriteLine("Are you sure this is the string you want to use? (Y/N)");
            string answer = Console.ReadLine();
            if (answer == "Y")
            {
                int count = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[i] == input[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(input[i] + " appears " + count + " times");
                    count = 0;
                }
            }
            else if (answer == "N")
            {
                Console.WriteLine("Please enter a new string");
                input = Console.ReadLine();
                int count = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[i] == input[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(input[i] + " appears " + count + " times");
                    count = 0;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid answer");
            }
        }
    }
}