using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms
{
    public class FactorialOfNmberUsingRecursion : IProgram
    {
        // Recursive function to calculate factorial
        public static int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * Factorial(n - 1);
        }

        public string Name => "Factorial of a number using recursion";
        
        public void Run()
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            int n = int.Parse(Console.ReadLine());

            int result = Factorial(n);
            Console.WriteLine($"The factorial of {n} is {result}.");
        }
    
    }
}
