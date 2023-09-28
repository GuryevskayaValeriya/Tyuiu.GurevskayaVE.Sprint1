using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint1.Task1.V0.Lib;

namespace Tyuiu.GurevskayaVE.Sprint1.Task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExxpression()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double b = 2.0;
            double c = 3.0;
            var res = ds.Calculate(a, b, c);

            Assert.AreEqual(1, res);
        }
    }
}
