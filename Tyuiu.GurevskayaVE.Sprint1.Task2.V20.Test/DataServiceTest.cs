using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint1.Task2.V20.Lib;


namespace Tyuiu.GurevskayaVE.Sprint1.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateSquaresSumm()
        {
            DataService Res = new DataService();
            int value = 2;
            int valueTwo = 3;
            var res = Res.CalculateSquaresSumm(value, valueTwo);

            Assert.AreEqual(13, res);
        }
    }
}
