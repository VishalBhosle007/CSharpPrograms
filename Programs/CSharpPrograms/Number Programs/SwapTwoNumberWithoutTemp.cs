using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.Number_Programs
{
    public class SwapTwoNumberWithoutTemp : IProgram
    {
        public string Name => "Swap two number without using third/Temp variable";

        public void Run()
        {
            int a = 0, b = 0;
            Console.Write("Enter value for A :");
            a = int.Parse(Console.ReadLine());
            
            Console.Write("Enter value for A :");
            b = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Before Swapping: a = {a}, b = {b}");

            // Swapping using tuple deconstruction
            (a, b) = (b, a);

            // Using arithmetic operations 
            //a = a + b;
            //b = a - b;
            //a = a - b;

            Console.WriteLine($"After Swapping: a = {a}, b = {b}");
        }
    }
}
