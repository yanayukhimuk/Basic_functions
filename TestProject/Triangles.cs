using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    class Triangles
    {
        protected int height;

        public int GetHeight()
        {
            Console.WriteLine("Enter the height: ");
            height = int.Parse(Console.ReadLine());
            return height;
        }
        public void DrawReversedTriangle(int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        public void DrawNormalTriangle(int height)
        {
            for (int i = 0; i <= height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }
    }
} 
