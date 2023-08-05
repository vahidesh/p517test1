using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntFactorialExtension.Extensions
{
    internal static class CustomExtensions
    {
        public static int Factorial(this int fact)
        {
            int factorial = 1;
            for (int j = fact; j > 0; j--)
            {
                factorial*=j;

            }
            return factorial;
        }
    }
}
