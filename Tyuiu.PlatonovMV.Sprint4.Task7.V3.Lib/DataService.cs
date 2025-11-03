using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PlatonovMV.Sprint4.Task7.V3.Lib
{
    public class DataService : ISprint4Task7V3
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int countOdd = 0;

            for (int i = 0; i < n; i++)        // строки
            {
                for (int j = 0; j < m; j++)    // стобцы
                {
                    
                    int num = int.Parse(value.Substring(i * m + j, 1));
                    matrix[i, j] = num;

                    if (num % 2 != 0)
                        countOdd++;
                }
            }

            return countOdd;
        }
    }
}