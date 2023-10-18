using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZuborevDA.Sprint2.Task3.V18.Lib
{
    public class DataService : ISprint2Task3V18
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
                y = Math.Pow(x, 2) * Math.Pow(((x + 1) / (x - 1)), x);
            }
            else
            {
                if (x==0)
                {
                    y = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
                }
                else
                {
                    if ((x > -22) && (x < 2))
                    {
                        y = Math.Pow((1 + (1 / Math.Pow(x, 2))), x);
                    }
                    else
                    {
                        if (x < -22)
                        {
                            y = x + 10 * x - (1 / x);
;                       }
                    }
                }
            }

            return y;
        }
    }
}
