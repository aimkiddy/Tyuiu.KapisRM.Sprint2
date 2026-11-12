using System;
using Tyuiu.KapisRM.Sprint2.Task6.V5.Lib;

namespace Tyuiu.KapisRM.Sprint2.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                  *");
            Console.WriteLine("* Тема: Получение результата из switch                                                                       *");
            Console.WriteLine("* Задание #6                                                                                                 *");
            Console.WriteLine("* Вариант #5                                                                                                 *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* По заданному номеру карты k (6 <= k <= 14) определить достоинство соответствующей карты                    *");
            Console.WriteLine("* (валету — 11, даме — 12, королю — 13, тузу — 14, остальные соответствуют своим названиям).                 *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            Console.Write("Введите номер карты k (от 6 до 14): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            if (k >= 6 && k <= 14)
            {
                string res = ds.FindCardValue(k);
                Console.WriteLine($"Достоинство карты: {res}");
            }
            else
            {
                Console.WriteLine("Введено неверное значение! Номер карты должен быть от 6 до 14.");
            }

            Console.ReadKey();
        }
    }
}