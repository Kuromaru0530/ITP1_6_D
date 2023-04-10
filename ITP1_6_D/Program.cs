using System;
using System.Linq;
using System.Collections.Generic;

namespace ITP1_6_D
{
    class Program
    {
        static void Main()
        {
            string[] Input = Console.ReadLine().Split(' ');
            var n = int.Parse(Input[0]);
            var m = int.Parse(Input[1]);

            int[,] A = new int[n, m];
            int[] b = new int[m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; m++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                } 
            }
            for (int k = 0; k < m; k++)
            {
                b[k] = int.Parse(Console.ReadLine());
            }

            for(int l = 0; l < n; l++)
            {

                for(int p = 0; p < m; p++)
                {

                }
            }
        }
    }
}