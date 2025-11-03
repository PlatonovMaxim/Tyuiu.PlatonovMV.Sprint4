using System;
using Tyuiu.PlatonovMV.Sprint4.Task5.V10.Lib;

namespace Tyuiu.PlatonovMV.Sprint4.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Платонов М. В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив 5x5, заполненный случайными числами в диапазоне    *");
            Console.WriteLine("* от -4 до 7. Найти сумму положительных элементов массива.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];
            Random rnd = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(-4, 8);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            DataService ds = new DataService();
            int result = ds.Calculate(matrix);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма положительных элементов массива = " + result);
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}