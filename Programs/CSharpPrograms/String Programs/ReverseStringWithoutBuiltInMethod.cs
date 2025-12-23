using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.String_Programs
{
    public class ReverseStringWithoutBuiltInMethod : IProgram
    {
        public string Name => "Reverse a string without using built-in methods";

        public void Run()
        {
            Console.WriteLine("Enter string to reverse");
            string str = Console.ReadLine();
            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }

            Console.WriteLine(rev);
        }
    }
}
