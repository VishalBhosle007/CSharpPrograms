using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms
{
    public class FactorialOfNmberUsingLoop : IProgram
    {
        public string Name => "Factorial of a number using loop";
        public void Run()
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            int n = int.Parse(Console.ReadLine());
            
            long factorial = 1;
            
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"The factorial of {n} is {factorial}.");
        }
    
    }
}
