using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms
{
    public class Sumofdigits : IProgram
    {
        public string Name => "Sum of digits of a number";

        public void Run()
        {
            Console.WriteLine("Enter number to get sum of digits");
            int? num = null;
            num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10 ?? 0;
                sum += digit;
                num = num / 10;
            }
            Console.WriteLine($"Sum of digits is {sum}");
        }
    }
}
