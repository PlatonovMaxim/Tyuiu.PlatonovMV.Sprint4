using System;
using Tyuiu.PlatonovMV.Sprint4.Task3.V19.Lib;

namespace Tyuiu.PlatonovMV.Sprint4.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Платонов М. В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив 5x5 из целых чисел в диапазоне от 3 до 9.          *");
            Console.WriteLine("* Найти количество чётных элементов во всём массиве.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = {
                { 6, 6, 5, 8, 3 },
                { 9, 4, 4, 3, 4 },
                { 3, 8, 8, 6, 4 },
                { 6, 6, 3, 3, 6 },
                { 9, 8, 5, 3, 7 }
            };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество чётных элементов массива = " + result);
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}