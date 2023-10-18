using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZuborevDA.Sprint2.Task2.V21.Lib;

namespace Tyuiu.ZuborevDA.Sprint2.Task2.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                  *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                         *");
            Console.WriteLine("* Задание #2                                                                 *");
            Console.WriteLine("* Вариант #21                                                                *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и   *");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области.  *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");

            Repeat:
            {
                Console.WriteLine("******************************************************************************");
                int x;
                Console.WriteLine("Введите значение переменной X: ");
                x = Convert.ToInt32(Console.ReadLine());

                int y;
                Console.WriteLine("Введите значение переменной Y: ");
                y = Convert.ToInt32(Console.ReadLine());

                bool res = ds.CheckDotInShadedArea(x, y);

                Console.WriteLine("******************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
                Console.WriteLine("******************************************************************************");
                if (res)
                {
                    Console.WriteLine("Точка находиться в заштрихованной области");
                }
                else
                {
                    Console.WriteLine("Точка не находиться в заштрихованной области");
                }

                Console.WriteLine("******************************************************************************");
                Console.WriteLine("Для повтора наберите y, для выхода n");
                Console.WriteLine("******************************************************************************");
                string answer = Console.ReadLine();
                if (answer == "y") goto Repeat;
                if (answer == "n") return;
            }
        }
    }
}
