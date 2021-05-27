/* Lab 1 Question 3
 * 
 * Diana Guerrero
 * Professor Aydin
 * BCS 426 
 * 2/7/21
 * 
 * Partner(s): Patrick Adams
 * Resource(s): 
 * 1. https://www.javatpoint.com/csharp-program-to-reverse-number
 * */

using System;

namespace BCS426Lab1Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 3 \n");

            int remainder, reverseNum = 0;

            // Enter a number to reverse
            Console.WriteLine("Enter a Number to Reverse: ");
            int n = int.Parse(Console.ReadLine());

            while( n > 0)
            {
                remainder = n % 10;
                reverseNum = reverseNum * 10 + remainder;
                n = n / 10;
            }

            // Everytime I try to concatinate n + "Reverse Number: " + reverseNum it registers n as 0 so I wasn't able to have a layout of "123321"
            Console.Write("Reverse Number: " + reverseNum);
        }
    }
}
