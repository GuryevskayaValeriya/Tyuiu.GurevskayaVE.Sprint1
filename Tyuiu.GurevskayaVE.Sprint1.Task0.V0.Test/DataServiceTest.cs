﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint1.Task0.V0.Lib;

namespace Tyuiu.GurevskayaVE.Sprint1.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExxpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();

            Assert.AreEqual(7, res);
        }
    }
}
