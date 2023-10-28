using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SafronovVV.Sprint3.Task4.V18.Lib;

namespace Tyuiu.SafronovVV.Sprint3.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startvalue = -5;
            int stopvalue = 5;
            double wait = 2.993;

            double res = ds.Calculate(startvalue, stopvalue);

            Assert.AreEqual(wait, res);
        }
    }
}
