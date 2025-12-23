using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.String_Programs
{
    public class CountOccurrencesOfCharacterInString : IProgram
    {
        public string Name => "Count occurrences of each character in a string";

        public void Run()
        {
            Console.WriteLine("Enter string to count occurrences of each character");
            string str = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(str))
                return;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in str.ToLower())
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            foreach (var ele in dict)
            {
                Console.WriteLine($"{ele.Key} = {ele.Value}");
            }
        }
    }
}
