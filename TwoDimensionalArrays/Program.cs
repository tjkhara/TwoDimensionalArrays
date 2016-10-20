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
            //CreateAndDisplayTwoDimensionalArray();
            DisplayDiagonalElements();
        }

        //The function below displays a 3 by 3 two dimensional array

        //static void CreateAndDisplayTwoDimensionalArray()
        //{
        //    int[,] array = new int[3, 3] { { 12, 11, 13 }, { 14, 1, 15 }, { 45, 75, 5 } };
            
        //    for(int i = 0; i < 3; i++)
        //    {
        //        for(int j = 0; j < 3; j++)
        //        {
        //            Console.Write(array[i, j] + " ");
        //        }

        //        Console.WriteLine();
        //    }
        //}

        // The function below displays the diagonal elements of a 3 by 3 two dimensional array

        static void DisplayDiagonalElements()
        {
            int[,] array = new int[3, 3] { { 12, 11, 13 }, { 14, 1, 15 }, { 45, 75, 5 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.Write(array[i, j] + " ");
                    } 
                }
            }
        }
    }
}
