using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZargarovAA.Sprint6.Task4.V16.Lib;

namespace Tyuiu.ZargarovAA.Sprint6.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcValid()
        {

            DataService DataService = new DataService();
            double[] array = { -36.41, -22.07, 5.68, 16.72, 8.35, -0.5, 9.63, 16.29, 5.01, -22.4, -36.3 };
            double[] wait = DataService.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(wait, array);
        }
    }
}