using System;
using Tyuiu.PlatonovMV.Sprint4.Task7.V3.Lib;

namespace Tyuiu.PlatonovMV.Sprint4.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Платонов М. В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление и завершение итогового проекта                         *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из цифр \"27182818\". Преобразовать её в матрицу 4x2          *");
            Console.WriteLine("* и подсчитать количество нечётных чисел в матрице.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "27182818";
            int n = 4, m = 2;
            int[,] matrix = new int[n, m];
            int index = 0;

            Console.WriteLine("Полученная матрица:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Convert.ToInt32(value[index].ToString());
                    Console.Write(matrix[i, j] + "\t");
                    index++;
                }
                Console.WriteLine();
            }

            DataService ds = new DataService();
            int result = ds.Calculate(n, m, value);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Количество нечётных элементов в матрице = {result}");
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}