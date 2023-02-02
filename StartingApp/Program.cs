// See https://aka.ms/new-console-template for more information
// ask a user to input a string and count the number of times each character appears in the string
//Ask the user if they are sure this is the string they want to use
//if the user says yes, then count the number of times each character appears in the string
//if the user says no, then ask them to input a new string
//only show each character once

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
            Console.WriteLine("Are you sure this is the string you want to use? (y/n)");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                Dictionary<char, int> charCount = new Dictionary<char, int>();
                foreach (char c in input)
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount.Add(c, 1);
                    }
                }
                foreach (KeyValuePair<char, int> kvp in charCount)
                {
                    Console.WriteLine("Character: {0}, Count: {1}", kvp.Key, kvp.Value);
                }
            }
            else
            {
                Console.WriteLine("Please enter a new string");
                string newInput = Console.ReadLine();
                Dictionary<char, int> charCount = new Dictionary<char, int>();
                foreach (char c in newInput)
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount.Add(c, 1);
                    }
                }
                foreach (KeyValuePair<char, int> kvp in charCount)
                {
                    Console.WriteLine("Character: {0}, Count: {1}", kvp.Key, kvp.Value);
                }
            }
        }
    }
}