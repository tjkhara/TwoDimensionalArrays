using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateAndDisplayTwoDimensionalArray();
        }

        static void CreateAndDisplayTwoDimensionalArray()
        {
            int[,] array = new int[3, 3] { { 12, 11, 13 }, { 14, 1, 15 }, { 45, 75, 5 } };
            
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
