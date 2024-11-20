using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1120
{
    public static class MyExtension
    {
        public static int DigitSum(this int x)
        {
            if (x == 0)
                return 0;

            int sum = 0;
            while (x > 0)
            {
                sum += x % 10;
                x = x / 10;
            }
            return sum;
        }
    }
}
