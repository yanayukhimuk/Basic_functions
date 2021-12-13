using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_functions
{
    class Operations
    {
        static double Division (int one, int two)
        {
            double res = (double)one / two;
            return res;
        }

        static double CalculateAverage(int a, int b)
        {
            double result = (double)(a + b) / 2;
            return result;
        }

        static void OperationsWithThreeDigits() { 

            Console.WriteLine("Введите числа a, b, c: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine()); 
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваши числа: " + a + " " + b + " " + c);

            int sum = a + b + c;
            Console.WriteLine("Сложение чисел: " + sum);

            int mult = a * b * c;
            Console.WriteLine("Произведение чисел: " + mult);
        }

    }
}
