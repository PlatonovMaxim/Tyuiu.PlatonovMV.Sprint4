using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PlatonovMV.Sprint4.Task3.V19.Lib
{
    public class DataService : ISprint4Task3V19
    {
        public int Calculate(int[,] array)
        {
            int count = 0;
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}