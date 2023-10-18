using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZuborevDA.Sprint2.Task3.V18.Lib;

namespace Tyuiu.ZuborevDA.Sprint2.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 36;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]

        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 3.0/4;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]

        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]

        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = -23;
            double res = ds.Calculate(x);
            double wait = -(5818.0/23);
            Assert.AreEqual(wait, res);
        }
    }
}
