using System;
namespace CsharpFunctionalProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            CoinFlip fn = new CoinFlip();
            fn.FlipCoin();
            LeapYear lp = new LeapYear();
            lp.CheckLeapYear();
            Pow2N pow = new Pow2N();
            pow.CalPow();
        }
    }
}