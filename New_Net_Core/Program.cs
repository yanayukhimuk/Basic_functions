using System;

namespace New_Net_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = { 2, 10, 5, 6, 77, 89 };
            //Console.WriteLine(myArray[^1]);

            //int[] myArray2 = myArray[1..4];

            //for (int i = 0; i < myArray2.Length; i++)
            //{
            //    Console.WriteLine(myArray2[i]);
            //}

            //string str = "I am the best of the best";
            //Console.WriteLine(str[^5..]);

            int[,] my2DArray = new int[5, 10];
                    
            int height = my2DArray.GetLength(0);
            int width = my2DArray.GetLength(1);

            Random random = new Random();


            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    my2DArray[i, k] = random.Next(100);
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    Console.Write(my2DArray[i, k] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            int[][] unusualArray = new int[3][];
            unusualArray[0] = new int[5];
            unusualArray[1] = new int[4];
            unusualArray[2] = new int[2];

            for (int i = 0; i < unusualArray.Length; i++)
            {
                for (int k = 0; k < unusualArray[i].Length; k++)
                {
                    unusualArray[i][k] = random.Next(20);
                }
            }

            for (int i = 0; i < unusualArray.Length; i++)
            {
                for (int k = 0; k < unusualArray[i].Length; k++)
                {
                    Console.Write(unusualArray[i][k] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine(); 


            int[,,] new3dArray = new int[4, 3, 5];
            int volume = new3dArray.GetLength(0);
            int height2 = new3dArray.GetLength(1);
            int width2 = new3dArray.GetLength(1);

            for (int i = 0; i < volume; i++)
            {
                for (int k = 0; k < height2; k++)
                {
                    for (int j = 0; j < width2; j++)
                    {
                        new3dArray[i, k, j] = random.Next(100);
                    }
                }
            }

            for (int i = 0; i < volume; i++)
            {
                Console.WriteLine("Page #" + (i+1));
                for (int k = 0; k < height2; k++)
                {
                    for (int j = 0; j < width2; j++)
                    {
                        Console.Write (new3dArray[i, k, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("##################"); 
            }


        }
    }
}
