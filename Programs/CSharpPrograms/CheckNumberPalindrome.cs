using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms
{
    public class CheckNumberPalindrome : IProgram
    {
        public string Name => "Check number is palindrome";

        public void Run()
        {
            Console.WriteLine("Enter a number to check if it is a palindrome:");
            int n = int.Parse(Console.ReadLine());

            int originalNumber = n;
            int reversedNumber = 0;
            while (n > 0)
            {
                int digit = n % 10;
                reversedNumber = reversedNumber * 10 + digit;
                n /= 10;
            }

            if (originalNumber == reversedNumber)
            {
                Console.WriteLine($"{originalNumber} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not a palindrome.");
            }
        }
    }
}
