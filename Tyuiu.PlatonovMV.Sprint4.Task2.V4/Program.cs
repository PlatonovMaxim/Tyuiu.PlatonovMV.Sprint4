using System;
using Tyuiu.PlatonovMV.Sprint4.Task2.V4.Lib;

namespace Tyuiu.PlatonovMV.Sprint4.Task2.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Платонов М. В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив из 13 элементов,                    *");
            Console.WriteLine("* заполненный случайными числами в диапазоне от 2 до 9.                   *");
            Console.WriteLine("* Найти сумму нечетных элементов массива.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[13];
            Random rnd = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2, 10);
                Console.Write(array[i] + " ");
            }

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма нечетных элементов массива = " + result);
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}