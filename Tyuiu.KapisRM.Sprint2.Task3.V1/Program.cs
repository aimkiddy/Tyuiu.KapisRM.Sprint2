using System;
using Tyuiu.KapisRM.Sprint2.Task3.V1.Lib;

namespace Tyuiu.KapisRM.Sprint2.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                  *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                                                        *");
            Console.WriteLine("* Задание #3                                                                                                 *");
            Console.WriteLine("* Вариант #1                                                                                                 *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с использованием вложенных операторов   *");
            Console.WriteLine("* if-else, где пользователь вводит значение переменной X с клавиатуры. Округлить до трех знаков.               *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            double res = ds.Calculate(x);

            Console.WriteLine($"Y = {res}");

            Console.ReadKey();
        }
    }
}