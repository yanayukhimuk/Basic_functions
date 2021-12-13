using System;
using System.Globalization;

namespace Basic_functions
{
    class Strings
    {
        const string str = "5";
        const string str2 = "3";

        int ParseString(string str)
        {
            int a = int.Parse(str);
            return a;
        }

        int ConvertStringToInt32()
        {
            string str;
            Console.WriteLine("Enter the number: ");
            str = Console.ReadLine();
            int a = Convert.ToInt32(str);
            return a;
        }

        double ConvertStringToDouble()
        {
            string str;
            Console.WriteLine("Enter the number: ");
            str = Console.ReadLine();
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
            numberFormatInfo.NumberDecimalSeparator = ".";
            double a = Convert.ToDouble(str, numberFormatInfo);
            return a;
        }

        double ParseStringToDouble()
        {
            string str = "5.9";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            double a = double.Parse(str, numberFormatInfo);
            return a;
        }

        static void ParseInvalidString (string str)
        {
            try
            {
                int a = Convert.ToInt32(str);
                Console.WriteLine("Успешная конвертация!");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка конвертации!");
            }
        }

        static void TryParseInvalidString(string str)
        {
            int a;
            bool result = int.TryParse(str, out a);

            if (result)
            {
                Console.WriteLine("Успешная конвертация!");
            }
            else
            {
                Console.WriteLine("Ошибка конвертации!");
            }
        }
    }
}
