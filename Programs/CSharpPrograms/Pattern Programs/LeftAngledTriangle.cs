using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.Pattern_Programs
{
    public class LeftAngledTriangle : IProgram
    {
        public string Name => "Print Left-angled triangle";
        /*
                *
                **
                ***
                ****
                *****

         */

        public void Run()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
