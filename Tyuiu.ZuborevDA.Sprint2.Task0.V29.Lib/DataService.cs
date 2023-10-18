﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZuborevDA.Sprint2.Task0.V29.Lib
{
    public class DataService : ISprint2Task0V29
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 629 == y;
            res[1] = x != y - 630;
            res[2] = x < y;
            res[3] = x + 631 > y;
            res[4] = x + 900 <= y;
            res[5] = x - 5 >= y;

            return res;
        }
    }
}