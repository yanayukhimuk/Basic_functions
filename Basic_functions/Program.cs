using System;

namespace Basic_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int rub, dol, euro;

            Console.WriteLine("Выберите тип валюты: rub, euro, dol");
            string currency = Console.ReadLine();
            
            switch(currency)
            {
                case "rub":
                    Console.WriteLine("Сколько рублей конвертировать?");
                    rub = int.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + rub + " рублей - это " 
                        + CurrencyConverter.RubToDollar(rub) + " долларов или " 
                        + CurrencyConverter.RubToEuro(rub) + " евро.");
                    break;
                case "dol":
                    Console.WriteLine("Сколько долларов конвертировать?");
                    dol = int.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + dol + " долларов - это " 
                        + CurrencyConverter.DollarToRub(dol) + " рублей или " 
                        + CurrencyConverter.DollarToEuro(dol) + " евро.");
                    break;
                case "euro":
                    Console.WriteLine("Сколько евро конвертировать?");
                    euro = int.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + euro + " евро - это " 
                        + CurrencyConverter.EuroToRub(euro) + " рублей или " 
                        + CurrencyConverter.EuroToDollar(euro) + " долларов.");
                    break;
                case null:
                    Console.WriteLine("Валюта не была выбрана");
                    break;
            }

        }

    }
}
