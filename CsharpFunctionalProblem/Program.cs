﻿using System;
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
                    case 1:
                        CoinFlip fn = new CoinFlip();
                        fn.FlipCoin();
                        break;
                    case 2:
                        LeapYear lp = new LeapYear();
                        lp.CheckLeapYear();
                        break;
                    case 3:
                        Pow2N pow = new Pow2N();
                        pow.CalPow();
                        break;
                    case 4:
                        HarmonicNumber hm = new HarmonicNumber();
                        hm.CalHarmonic();
                        break;
                    case 5:
                        break;
                    case 6:
                        QuoRem quoRem = new QuoRem();
                        quoRem.FindQuoRem();
                        break;
                    case 12:
                        flag = false;
                        break;
                }
            }




        }
    }
}