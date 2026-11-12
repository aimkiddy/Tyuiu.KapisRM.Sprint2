using System;
using Tyuiu.KapisRM.Sprint2.Task2.V19.Lib;

namespace Tyuiu.KapisRM.Sprint2.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                  *");
            Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                                                         *");
            Console.WriteLine("* Задание #2                                                                                                 *");
            Console.WriteLine("* Вариант #19                                                                                                *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и вычисляет,                             *");
            Console.WriteLine("* находится ли точка с координатами X, Y в заштрихованной области.                                           *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            Console.Write("Введите значение X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области.");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области.");
            }

            Console.ReadKey();
        }
    }
}