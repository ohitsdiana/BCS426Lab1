/* Lab 1 Question 4
 * 
 * Diana Guerrero
 * Professor Aydin
 * BCS 426 
 * 2/7/21
 * 
 * Partner(s): Patrick Adams
 * Resource(s): 
 * 1. https://www.geeksforgeeks.org/program-to-check-the-validity-of-a-password/
 * */

using System;

namespace BCS426Lab1Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 4");

            int count = 0;

            // Length between 6 and 15 characters.
            int minLength = 6;
            int maxLength = 15;

            // Ask user to enter a password
            Console.WriteLine("Enter a Password: ");
            string password = Console.ReadLine();

            // At least one digit (0-9).
            for (int i = 0; i <= 9; i++)
            {
                // Converting int to string 
                String str1 = i.ToString();

                if (password.Contains(str1))
                {
                    count = 1;
                }
            }

            // At least one lowercase letter (a-z).


        }
    }
}
