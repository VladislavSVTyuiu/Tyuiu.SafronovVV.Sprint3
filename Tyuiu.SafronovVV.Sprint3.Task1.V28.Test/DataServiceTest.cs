using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SafronovVV.Sprint3.Task1.V28.Lib;

namespace Tyuiu.SafronovVV.Sprint3.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0;
            int startValue = 1;
            int stopValue = 2;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.5;
            Assert.AreEqual(wait, res);
        }
    }
}
