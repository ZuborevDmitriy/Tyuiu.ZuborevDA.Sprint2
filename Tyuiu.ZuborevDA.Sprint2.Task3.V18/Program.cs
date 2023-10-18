using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZuborevDA.Sprint2.Task3.V18.Lib;

namespace Tyuiu.ZuborevDA.Sprint2.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                  *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                        *");
            Console.WriteLine("* Задание #3                                                                 *");
            Console.WriteLine("* Вариант #18                                                                *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y         *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит       *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до трех  *");
            Console.WriteLine("* знаков после запятой;                                                      *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            double x;
            Console.WriteLine("*Введите значение переменной X: *");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            double res = ds.Calculate(x);
            double result = Math.Round(res, 3);
            Console.WriteLine($"Значение функции = {result}");
            Console.ReadLine();
        }
    }
}
