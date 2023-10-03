using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint1.Task4.V28.Lib;

namespace Tyuiu.GurevskayaVE.Sprint1.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 0.002;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
