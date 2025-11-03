using System;
using Tyuiu.PlatonovMV.Sprint4.Task6.V28.Lib;

namespace Tyuiu.PlatonovMV.Sprint4.Task6.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Платонов М. В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив:\"Река, Озеро, Болото, Овчар, Луна, Море\".          *");
            Console.WriteLine("* Используя класс Array, вывести элементы, длина которых равна 4 символам.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = { "Река", "Озеро", "Болото", "Овчар", "Луна", "Море" };

            Console.WriteLine("Исходный массив:");
            Array.ForEach(array, x => Console.Write(x + " "));

            DataService ds = new DataService();
            string[] result = ds.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Слова длиной 4 символа:");
            Array.ForEach(result, x => Console.Write(x + " "));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}