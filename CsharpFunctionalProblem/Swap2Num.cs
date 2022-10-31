using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalProblem
{
    internal class Swap2Num
    {
        public void Swap()
        {
            int a = 10, b = 20;
            Console.WriteLine("Number Before swap a : {0} and b : {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Number After swap a : {0} and b : {1}", a, b);

        }
    }
}
