using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionalProblem
{
    internal class LeapYear
    {
        int year = 2000;
        public bool findLeapYear()
        {
            if (year % 400 == 0)
                return true;
            if (year % 100 == 0)
                return false;
            if (year % 4 == 0)
                return true;
            return false;
        }
        public void CheckLeapYear()
        {
            Console.Write(findLeapYear() ? "Leap Year" : "Not a Leap Year");
        }
        
    }
}
