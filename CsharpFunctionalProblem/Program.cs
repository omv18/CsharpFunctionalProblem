using System;
namespace CsharpFunctionalProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                int val = Convert.ToInt32(Console.ReadLine());
                switch (val)
                {
                    case 0:
                        CoinFlip fn = new CoinFlip();
                        fn.FlipCoin();
                        break;
                    case 1:
                        LeapYear lp = new LeapYear();
                        lp.CheckLeapYear();
                        break;
                    case 2:
                        Pow2N pow = new Pow2N();
                        pow.CalPow();
                        break;
                    case 3:
                        HarmonicNumber hm = new HarmonicNumber();
                        hm.CalHarmonic();
                        break;
                }
            }




        }
    }
}