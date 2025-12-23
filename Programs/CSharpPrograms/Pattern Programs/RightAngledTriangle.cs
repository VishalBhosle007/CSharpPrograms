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

        /*
                    *
                   **
                  ***
                 ****
                *****

        */
        public void Run()
        {
            int rows = 5;


            for (int i = 1; i <= rows; i++)
            {
                // Print spaces
                for (int space = rows - i; space > 0; space--)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int star = 1; star <= i; star++)
                {
                    Console.Write("*");
                }

                // Print new line
                Console.WriteLine();
            }
        }
    }
}
