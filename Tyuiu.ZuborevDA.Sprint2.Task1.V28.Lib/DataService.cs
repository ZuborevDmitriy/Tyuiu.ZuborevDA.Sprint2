using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZuborevDA.Sprint2.Task1.V28.Lib
{
    public class DataService : ISprint2Task1V28
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a + 400 == b) | (c == d);
            res[1] = (b + 17 != c) & (a != 654 - 54);
            res[2] = (c - 2 > b) || (a < d);
            res[3] = (c > d) && (a < b);
            res[4] = !(!res[0]);
            res[5] = (d == c) ^ (c == b + 17);
            
            return res;
        }
    }
}