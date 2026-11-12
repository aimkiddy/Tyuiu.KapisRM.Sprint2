using System;
using Tyuiu.KapisRM.Sprint2.Task0.V10.Lib;

namespace Tyuiu.KapisRM.Sprint2.Task0.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                  *");
            Console.WriteLine("* Тема: Операции сравнения                                                                                   *");
            Console.WriteLine("* Задание #0                                                                                                 *");
            Console.WriteLine("* Вариант #10                                                                                                *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=) и арифметических выражений,                  *");
            Console.WriteLine("* которая вернет логическую последовательность (массив): (False, True, False, True, False, True),            *");
            Console.WriteLine("* при x = 1305, y = 475.                                                                                     *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            int x = 1305;
            int y = 475;

            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            bool[] result = ds.GetCompareOperations(x, y);

            Console.WriteLine("Логическая последовательность (массив):");
            Console.WriteLine($"({string.Join(", ", result)})");

            Console.ReadKey();
        }
    }
}