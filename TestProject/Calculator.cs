using System;

namespace TestProject
{
    class Calculator
    {
        int firstNumb, secondNumb;
        double res;
        char oper, answer;

        public int GetFirstNumber()
        {
            Console.WriteLine("Enter the first number: ");
            firstNumb = int.Parse(Console.ReadLine());
            return firstNumb;
        }

        public int GetSecondNumber()
        {
            Console.WriteLine("Enter the second number: ");
            secondNumb = int.Parse(Console.ReadLine());
            return secondNumb;
        }

        public char GetOperation()
        {
            Console.WriteLine("Enter the operation: +, -, /, *: ");
            oper = char.Parse(Console.ReadLine());
            return oper;
        }
        public void Calculate(int firstNumb, int secondNumb, char oper)
        {
            do
            {
                switch (oper)
                {
                    case '+':
                        res = (double)firstNumb + secondNumb;
                        Console.WriteLine("The result is: " + res);
                        break;
                    case '-':
                        res = (double)firstNumb - secondNumb;
                        Console.WriteLine("The result is: " + res);
                        break;
                    case '/':
                        if (secondNumb != 0)
                        {
                            res = (double)firstNumb / secondNumb;
                            Console.WriteLine("The result is: " + res);
                        }
                        else
                        {
                            Console.WriteLine("Can't devide into 0! ");
                            break;
                        }
                        break;
                    case '*':
                        res = (double)firstNumb * secondNumb;
                        Console.WriteLine("The result is: " + res);
                        break;
                }

                Console.WriteLine("Do you want to continue? (y / n): ");
                answer = char.Parse(Console.ReadLine());
            } while (answer != 'n');
        }


    }
}
