﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZuborevDA.Sprint2.Task7.V9.Lib;

namespace Tyuiu.ZuborevDA.Sprint2.Task7.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                    *");
            Console.WriteLine("* Задание #7                                                                 *");
            Console.WriteLine("* Вариант #9                                                                 *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные              *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами     *");
            Console.WriteLine("* X,Y в заштрихованной области.                                              *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Введите значение переменной X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            
            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }
            
            Console.ReadKey();
        }
    }
}
