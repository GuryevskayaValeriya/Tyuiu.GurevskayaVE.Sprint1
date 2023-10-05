using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint1.Task7.V7.Lib;

namespace Tyuiu.GurevskayaVE.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService Res = new DataService();
            double x = 1;
            double y = 1;
            double z = Res.Calculate(x, y);
            Assert.AreEqual(7.118, z);
        }
    }
}
