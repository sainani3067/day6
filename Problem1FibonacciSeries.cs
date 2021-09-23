using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6__problems
{
    class Problem1FibonacciSeries
    {
        public static int n { get; private set; }

        public static int Fibonacciseries()
        {
            int firstnumber = 0, secondnumber = 1, result = 0;
            if (n == 0) return 0; //It will return the first number of the series
            if (n == 1) return 1; // it will return  the second number of the series
            for (int i = 2; i <= n; i++)  // main processing starts from here
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }
            return result;
        }
    }
}     

