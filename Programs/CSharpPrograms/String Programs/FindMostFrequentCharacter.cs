using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Mime;

namespace Programs.CSharpPrograms.String_Programs
{
    public class FindMostFrequentCharacter : IProgram
    {
        public string Name => "Find most frequent character from string";

        public void Run()
        {
            Console.WriteLine("Enter string to find most frequent character");
            string str = Console.ReadLine();

            Dictionary<char, int> dict = new Dictionary<char, int>();
            // Count occurrences of each character 
            foreach (char c in str.Replace(" ", ""))
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }

            char? FrequentChar = null;
            int max = 0;

            // Find Maximum value and assign key as frequent char
            foreach(var item in dict)
            {
                if(max < item.Value)
                {
                    max = item.Value;
                    FrequentChar = item.Key;
                }
            }

            Console.WriteLine($"Most frequent char is : '{FrequentChar}' Count : {max}");
        }
    }
}
