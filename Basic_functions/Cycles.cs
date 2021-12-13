using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_functions
{
    class Cycles
    {
        public static int Fibonachi(int n)
        {
            int first = 0;
            int second = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = first;
                first = second;
                second = temp + second;
            }
            return first;
        }

        public static int Factorial(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
                return n * Factorial(n - 1);
        }

        public static void FactorialCycle()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(Factorial(i));
            }
        }
    }
}
