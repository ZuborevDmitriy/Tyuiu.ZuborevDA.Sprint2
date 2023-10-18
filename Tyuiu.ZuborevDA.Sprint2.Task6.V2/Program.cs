using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZuborevDA.Sprint2.Task6.V2.Lib;

namespace Tyuiu.ZuborevDA.Sprint2.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                  *");
            Console.WriteLine("* Тема: Получение результата из switch                                       *");
            Console.WriteLine("* Задание #6                                                                 *");
            Console.WriteLine("* Вариант #2                                                                 *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора  *");
            Console.WriteLine("* switch вычисляет требуемое значение и возвращает результат. Условие: По    *");
            Console.WriteLine("* данному месяцу, определите в какую пору года попадает этот месяц (Зима,    *");
            Console.WriteLine("* Лето, Весна, Осень).                                                       *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("*Введите номер месяца: *");
            int numMonth = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((numMonth > 12) || (numMonth < 1))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = $"Этот месяц попадает в время года: {ds.FindMonthSeason(numMonth)}";
            }

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
