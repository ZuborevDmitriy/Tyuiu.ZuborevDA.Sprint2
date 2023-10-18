using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZuborevDA.Sprint2.Task5.V4.Lib;

namespace Tyuiu.ZuborevDA.Sprint2.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                  *");
            Console.WriteLine("* Тема: Оператор switch                                                      *");
            Console.WriteLine("* Задание #5                                                                 *");
            Console.WriteLine("* Вариант #4                                                                 *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуемое *");
            Console.WriteLine("* значение и возвращает результат. Условие: Мастям игральных карт условно    *");
            Console.WriteLine("* присвоены следующие порядковые номера: масти «пики» — 1, масти «трефы» — 2,*");
            Console.WriteLine("* масти «бубны» — 3, масти «червы» — 4. По заданному номеру масти            *");
            Console.WriteLine("* m (1 <= m <= 4) определить название соответствующей масти.                 *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("*Введите номер масти: *");
            int numSuit = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((numSuit > 4) || (numSuit < 1))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = $"Это масть {ds.FindCardSuit(numSuit)}";
            }

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
