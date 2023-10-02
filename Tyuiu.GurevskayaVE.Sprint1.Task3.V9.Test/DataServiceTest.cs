using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint1.Task3.V9.Lib;

namespace Tyuiu.GurevskayaVE.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckConvertMinutesToHours()
        {
            DataService Res = new DataService();
            int minutes = 120;
            var res = Res.ConvertMinutesToHours(minutes);

            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void CheckConvertMinutesToHours1()
        {
            DataService Res = new DataService();
            int minutes = 120;
            var res = Res.ConvertMinutesToHours1(minutes);

            Assert.AreEqual(0, res);
        }
    }
}
