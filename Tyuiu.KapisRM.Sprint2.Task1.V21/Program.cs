using System;
using Tyuiu.KapisRM.Sprint2.Task1.V21.Lib;

namespace Tyuiu.KapisRM.Sprint2.Task1.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                  *");
            Console.WriteLine("* Тема: Логические операции                                                                                  *");
            Console.WriteLine("* Задание #1                                                                                                 *");
            Console.WriteLine("* Вариант #21                                                                                                *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций, которая вернет логическую                    *");
            Console.WriteLine("* последовательность (массив): (False, False, False, False, True, False), при a = 696, b = 987, c = 696, d = 155 *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            int a = 696;
            int b = 987;
            int c = 696;
            int d = 155;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            bool[] result = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("Логическая последовательность (массив):");
            Console.WriteLine($"({string.Join(", ", result)})");

            Console.ReadKey();
        }
    }
}