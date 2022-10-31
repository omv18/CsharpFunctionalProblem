using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalProblem
{
    internal class Primefactor
    {
        public int UserInput()
        {
            Console.Write("Enter Number to find the prime factorial : ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        public void Prime()
        {
            int num = UserInput();
            for(int i = 2; i < num; i++)
            {
                while(num % i == 0)
                {
                    Console.Write(i + " ");
                    num /= i;
                }
            }
            if(num >= 2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
