using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.Array_Programs
{
    public class CheckTwoArraysAreEqual : IProgram
    {

        public bool CheckTwoArraysEqual(int[] arr1, int[] arr2)
        {
            // Check length are equal
            if (arr1.Length != arr2.Length)
                return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            return true;
        }
        public string Name => "Check if two arrays are equal (same elements & same order).";

        public void Run()
        {
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 1, 5, 3, 4 };

            var result = CheckTwoArraysEqual(arr1, arr2);
            Console.WriteLine(result ? "Arrays are equal" : "Arrays are not equal");
        }
    }
}
