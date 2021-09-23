using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6__problems
{
    class Problem5CouponNumber
    {
        static char[] code = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public static void CouponNumbers()
        {

            Console.Write("Enter number of coupons that you want to generate :   ");
            int num = Convert.ToInt32(Console.ReadLine());

            int couponLength = 8;
            Random random = new Random();
            int couponNumberr = 0;
            for (int couponNumber = 1; couponNumber <= num; couponNumberr++)
            {

                StringBuilder str = new StringBuilder();
                for (int i = 0; i < couponLength; i++)
                {

                    int position = random.Next(0, code.Length);
                    str.Append(code[position]);
                }
                Console.WriteLine("'\n\nCoupon Code-{0}:  {1}", couponNumber, str);
            }
        }
    }
}