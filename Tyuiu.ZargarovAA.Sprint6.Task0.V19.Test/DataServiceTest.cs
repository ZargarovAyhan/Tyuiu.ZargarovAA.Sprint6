using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZargarovAA.Sprint6.Task0.V19.Lib;

namespace Tyuiu.ZargarovAA.Sprint6.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = -1;
            Assert.AreEqual(wait, res); 
        }
    }
}
