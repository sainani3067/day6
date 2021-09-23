using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day6__problems
{
    class Problem6StopWatch
    {
        public static void TimeElapsed()
        {
            Console.WriteLine("Stopwatch is running....");
            //Create new stopwatch.
            Stopwatch timer = new Stopwatch();

            //Begin timing.
            timer.Start();

            //Do something.
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }

            timer.Stop();
            Console.WriteLine(" Time elapsed: {0} ", timer.Elapsed);
        }
    }
}