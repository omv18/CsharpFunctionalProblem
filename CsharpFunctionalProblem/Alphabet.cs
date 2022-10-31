using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalProblem
{
    internal class Alphabet
    {
        public void CheckAlpha()
        {
            char ch = Console.ReadLine()[0];
            switch (ch)
            {
                case 'A' or 'a':
                case 'E' or 'e':
                case 'I' or 'i':
                case 'O' or 'o':
                case 'U' or 'u':
                    Console.WriteLine("{0} is Vowel",ch);
                    break;
                default :
                    Console.WriteLine("{0} is Constant", ch);
                    break;
            }
        }
    }
}
