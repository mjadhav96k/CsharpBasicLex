using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOuts
{

class MultiDimensionalArray
    {
        static void Main(string[] args)
        {
            // 2-D array syntax - int[row, column]
            int[,] twoD = new int[3, 3] {
                                               { 1, 2, 3 },
                                               { 4, 5, 6 },
                                               { 7, 8, 9 }
                                          };
            // Outer for loop represents rows                              
            for (int i = 0; i < 3; i++)
            {
                // Inner for loop represents columns of the current row
                for (int j = 0; j < 3; j++)
                {
                    // twoD[i, j] is equal to twoD[row, column]
                    Console.Write(twoD[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    // The Console.Write() and Console.WriteLine() are used just for formatting
    // the output display

    // Similarly declare a 3-dimensional array and access its elements

}

