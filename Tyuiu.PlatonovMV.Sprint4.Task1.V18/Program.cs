using System;
using Tyuiu.PlatonovMV.Sprint4.Task1.V18.Lib;

namespace Tyuiu.PlatonovMV.Sprint4.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Платонов М. В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан массив из 16 элементов (ввод с клавиатуры).                         *");
            Console.WriteLine("* Найти сумму нечетных элементов массива.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[16];

            Console.WriteLine("Введите 16 элементов массива (значения от 3 до 9):");
            for (int i = 0; i < 16; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
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