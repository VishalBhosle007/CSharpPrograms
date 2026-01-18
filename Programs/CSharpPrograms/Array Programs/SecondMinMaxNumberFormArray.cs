using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.Array_Programs
{
    public class SecondMinMaxNumberFormArray : IProgram
    {
        public string Name => "Find second largest and second smallest element in an array";

        public void Run()
        {
            int[] arr = { 1, 2, 3, 5, 6, 7, 8, 9 };

            int min = int.MaxValue;
            int secondMin = int.MaxValue;
            int max = int.MinValue;
            int secondMax = int.MinValue;

            foreach (int num in arr)
            {
                //Min
                if (num < min)
                {
                    secondMin = min;
                    min = num;
                }
                else if (num > min && num < secondMin)
                {
                    secondMin = num;
                }

                //Max
                if (num > max)
                {
                    secondMax = max;
                    max = num;
                }
                else if (num < max && num > secondMax)
                {
                    secondMax = num;
                }

            }

            Console.WriteLine($"Min = {min}, Max = {max}");
            Console.WriteLine($"Second Min = {secondMin}, Second Max = {secondMax}");
        }
    }
}
