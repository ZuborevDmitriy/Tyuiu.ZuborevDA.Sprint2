using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZuborevDA.Sprint2.Task4.V4.Lib;

namespace Tyuiu.ZuborevDA.Sprint2.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 6;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            double res = ds.Calculate(x, y);
            double wait = 1;
            Assert.AreEqual(res, wait);
        }
    }
}
