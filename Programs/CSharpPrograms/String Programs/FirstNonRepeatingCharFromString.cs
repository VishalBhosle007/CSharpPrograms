using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.String_Programs
{
    public class FirstNonRepeatingCharFromString : IProgram
    {
        public string Name => "Find first non-repeating character in a string";

        public void Run()
        {
            Console.WriteLine("Enter a string to find the first non-repeating character:");
            string input = Console.ReadLine() ?? "";

            Dictionary<char, int> charCount = new Dictionary<char, int>();
            
            // Count occurrences of each character
            foreach (char c in input.ToLower())
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            char? result = null;

            // Find the first non-repeating character
            foreach (char c in input.ToLower())
            {
                if (charCount[c] == 1)
                {
                    result = c;
                    break;
                }
            }

            if (result != null)
            {
                Console.WriteLine($"The first non-repeating character is: {result}");
            }
            else
            {
                Console.WriteLine("All characters are repeating.");
            }
        }
    }
}
