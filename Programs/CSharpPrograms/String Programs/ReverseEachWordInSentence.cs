using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.String_Programs
{
    public class ReverseEachWordInSentence : IProgram
    {
        public string Name => "Reverse each word in sentence";

        public void Run()
        {
            Console.WriteLine("Enter string to reverse each word");
            string str = Console.ReadLine();

            StringBuilder revStr = new StringBuilder();
            StringBuilder word = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] != ' ')
                {
                    word.Append(str[i]);
                }
                else
                {
                    for (int j = word.Length-1; j >= 0; j--)
                    {
                        revStr.Append(word[j]);
                    }
                    revStr.Append(' ');
                    word.Clear();
                }

            }

            // Reverse last word
            for (int j = word.Length-1; j >= 0; j--)
            {
                revStr.Append(word[j]);
            }


            Console.WriteLine(revStr.ToString());

        }
    }
}
