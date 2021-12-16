using System;

namespace Methods_and_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            char s;
            uint times;
            s = GetSymbol();
            times = GetHowmanyTimesShowChar();
            PrintString(s, times);

            int[] arr = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("What number do you want to find?");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("The index of " + value + " is: " + GetIndexOfElement(arr, value));
        }

        static char GetSymbol()
        {
            char symb;
            Console.WriteLine("Enter your symbol or letter: ");
            symb = char.Parse(Console.ReadLine());
            return symb;
        }

        static uint GetHowmanyTimesShowChar()
        {
            uint times;
            Console.WriteLine("Enter how many times you want to show the symbol: ");
            times = uint.Parse(Console.ReadLine());
            return times;
            
        }

        static void PrintString(char str, uint t)
        {
            for (int i = 0; i < t; i++)
            {
                Console.Write(str);
            }
        }

        static int GetIndexOfElement(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
