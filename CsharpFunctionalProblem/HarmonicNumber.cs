using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalProblem
{
    internal class HarmonicNumber
    {
        public int InputValue()
        {
            Console.WriteLine("Enter the Nth value to find the Harmonic value : ");
            int N = Convert.ToInt32(Console.ReadLine());
            return N;
        }
        public void CalHarmonic()
        {
            int N = InputValue();
            float harmonic = 1;
            for(int i = 0; i < N; i++)
            {
                harmonic += (float)1 / N;
            }
            Console.WriteLine("Harmonic value upto "+ N + " : "+harmonic);
        }
    }
}
