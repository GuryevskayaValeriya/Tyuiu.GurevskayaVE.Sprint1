using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint1.Task5.V5.Lib;

namespace Tyuiu.GurevskayaVE.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService Res = new DataService();
            double x = 32.527;
            int d = Res.Calculate(x);
            Assert.AreEqual(5, d);
        }
    }
}