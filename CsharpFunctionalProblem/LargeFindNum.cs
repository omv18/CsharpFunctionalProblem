using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalProblem
{
    internal class LargeFindNum
    {
        public int UserInput()
        {
            Console.Write("Enter the number : ");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        public void CheckLarge()
        {
            int a = UserInput();
            int b = UserInput();
            int c = UserInput();
            if (a > b & a > c)
            {
                Console.WriteLine("{0} is geatest", a);
            }
            else if (b > c & b > a)
            {
                Console.WriteLine("{0} is greatest", b);
            }
            else
            {
                Console.WriteLine("{0} is greatest", c);
            }
        }

    }
}
