using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal static class IntExtention
    {
        // 12345 --> 54321
        // Extention method
        public static int Reverse(this int n)
        {
            int ReversedNum = 0;
            int lastDigit;
            while (n > 0)
            {
                lastDigit = n % 10;
                ReversedNum = ReversedNum * 10 + lastDigit;
                n /= 10;
            }
            return ReversedNum;
        }
    }

}
