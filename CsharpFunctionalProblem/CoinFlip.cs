using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace CsharpFunctionalProblem
{
    internal class CoinFlip
    {
        Random random = new Random();
        public double CoinToss()
        {   
            double number = random.NextDouble();
            return number;
        }
        
        public void FlipCoin()
        {
            double count = 0, headCount = 0, tailCount = 0, coinFlip;
            Console.Write("Enter number of COIN flip for the toss : ");
            coinFlip = Convert.ToInt32(Console.ReadLine());
            while(coinFlip != count)
            {
                count++;
                double toss = CoinToss();
                if(toss < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
            }

            double he = (double)((headCount * 100) / coinFlip);
            double ta = (double)((tailCount * 100) / coinFlip);
            Console.WriteLine("Winning percentage of HEAD is : " +he);
            Console.WriteLine("Winning percentage of TAIL is : " +ta);

        }
    }
}



