using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.Pattern_Programs
{
    public class RightAngledTriangle : IProgram
    {
        public string Name => "Print Right-angled triangle";

        public void Run()
        {
            int n = 5;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
