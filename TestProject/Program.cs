using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 21, 3432, 4, 67 };
            //Console.WriteLine(myArray.Where(i=> i% 2 == 0).Sum()); // ?
            //Console.WriteLine(myArray.Where(i => i % 2 == 0).Min());

            int[] newArray = { 1, 20, 3432, 4, 56 };

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < newArray.Length; j++)
                {
                    if (myArray[i] == newArray[j])
                    {
                        Console.WriteLine(myArray[i]);
                    }
                    else
                        continue;
                }
            }

            Array.Sort(newArray);
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }

        }
    }
}
