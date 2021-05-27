/* Lab 1 Questions 1 & 2
 * 
 * Diana Guerrero
 * Professor Aydin
 * BCS 426 
 * 2/7/21
 * 
 * Partner(s): Patrick Adams
 * Question 1 Resource(s): 
 * 1. https://www.w3resource.com/csharp-exercises/data-types/csharp-data-type-exercise-2.php
 * 2. https://www.w3resource.com/csharp-exercises/for-loop/csharp-for-loop-exercise-20.php
 * 
 * Question 2 Resource(s):
 * 1. https://www.c-sharpcorner.com/blogs/triangle-diamond-pattern-programming-in-c-sharp
 * 2. https://forgetcode.com/csharp/2034-printing-a-diamond-pattern
 */

using System;

namespace BCS426Lab1Q1_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Question 1 & 2 \n");

            // Ask the user to enter a character
            Console.Write("Enter A Character: ");
            string s = Console.ReadLine();

            // Ask the user to enter the number of rows
            Console.Write("Enter The Number Of Rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write(" ");

            // Display number of lines
            for (int i = 0; i <= rows; i++)
            {
                // Number of characters per line
                for (int x = 1; x <= rows - i; x++)
                    Console.Write(" ");

                // Multiples number of characters
                for (int x = 1; x <= 2 * i - 1; x++)
                {
                    Console.Write(s);
                }

                Console.WriteLine();
            }

            // Diamond Shape Question 2

            // Reverse the outer loop on line 39
            for (int i = rows - 1; i >= 1; i--)
            {
                for (int x = 1; x <= rows - i; x++)
                    Console.Write(" ");
                for (int x = 1; x <= 2 * i - 1; x++)
                {
                    // Prints character in reverse
                    Console.Write(s);                   
                }
                Console.WriteLine();
            }
        }
    }
}
