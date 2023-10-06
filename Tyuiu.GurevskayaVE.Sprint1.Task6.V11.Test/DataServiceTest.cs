using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint1.Task6.V11.Lib;

namespace Tyuiu.GurevskayaVE.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCheckeFirstLetterRepetition()
        {
            DataService Res = new DataService();
            string value = "abcda";
            bool res = Res.CheckeFirstLetterRepetition(value);
            Assert.AreEqual(true, res);
        }
    }
}
