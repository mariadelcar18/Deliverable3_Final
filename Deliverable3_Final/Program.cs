/* Author: Maria del Carmen Perez-Soto de Paiva
 * Date: 1/26/2023
 * Description: Create a C# Console Application with iterative statements
 */

using System;
using System.ComponentModel;

namespace Deliverable3_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a try-catch statement to limit user input
            try
            {
                // Requesting numerical input
                Console.Write("Please enter an integer value between 1 and 100: ");
                int input = int.Parse(Console.ReadLine());

                // Specifing condition for numercial input 
                if (input >= 1 && input <= 100)
                {
                    // Requesting string input
                    Console.Write("Please specify the series type: Even or Odd: ");
                    string series = Console.ReadLine();

                    // Specifing condition for string input "Odd"
                    if (series == "Odd")
                    {
                        Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are: ");
                        for (int i = 1; i <= input; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                    }

                    // Specifing condition for string input "Even"
                    else if (series == "Even")
                    {
                        Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are: ");
                        for (int i = 0; i <= input; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                    }

                    // Specifing condition other scenarios
                    else
                    {
                        Console.WriteLine("Please specify the series type.");
                    }
                }

                // Specifing condition other scenarios
                else
                {
                    Console.WriteLine("Please enter a numeric integer value between 1 and 100.");
                }
            }

            // Catching Exceptions
            catch
            {
                Console.WriteLine("Please enter a numeric integer value between 1 and 100.");
            }
        }
    }
}