using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Programs.CSharpPrograms.Array_Programs
{
    public class BubbleSortArray : IProgram
    {
        public string Name => "Sort Array using Bubble sort";

        public void Run()
        {
            int[] arr = { 5, 1, 4, 2, 8 };

            Console.WriteLine("Original Array:");
            Console.WriteLine(string.Join(',', arr));

            int n = arr.Length;
            bool swapped;

            // Loop for passes
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                // Compare adjacent elements
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }

                // If no swaps occurred, array is already sorted
                if (!swapped)
                {
                    break;
                }
            }


            Console.WriteLine("After Sorting:");
            Console.WriteLine(string.Join(',', arr));



        }
    }
}
