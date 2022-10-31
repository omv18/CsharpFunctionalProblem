using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalProblem
{
    internal class Pow2N
    {
        public void CalPow()
        {
            for(int i = 0; i < 31; i++)
            {
                double pow = Math.Pow(2, i);
                Console.WriteLine("2 ^ " +i+" = "+ pow);
            }
            
        }
    }
}
