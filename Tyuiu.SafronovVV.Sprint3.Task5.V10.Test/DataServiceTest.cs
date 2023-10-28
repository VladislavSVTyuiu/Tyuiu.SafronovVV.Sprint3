using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SafronovVV.Sprint3.Task5.V10.Lib;

namespace Tyuiu.SafronovVV.Sprint3.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3, start1 = 1, end1 = 3, start2 = 1, end2 = 5;
            double res = ds.GetSumSumSeries(x, start1, start2, end1, end2);
            double wait = 1245;

            Assert.AreEqual(wait, res);
        }
    }
}
