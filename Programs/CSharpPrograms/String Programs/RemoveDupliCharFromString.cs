using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.String_Programs
{
    public class RemoveDupliCharFromString : IProgram
    {
        public string Name => "Remove duplicate characters from a string.";

        public void Run()
        {
            Console.WriteLine("Enter a string to remove duplicate characters:");
            string input = Console.ReadLine() ?? "";

            HashSet<char> seen = new HashSet<char>();
            StringBuilder resultBuilder = new StringBuilder();

            foreach (char c in input.ToLower())
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    resultBuilder.Append(c);
                }
            }

            Console.WriteLine(resultBuilder.ToString());
        }
    }
}
