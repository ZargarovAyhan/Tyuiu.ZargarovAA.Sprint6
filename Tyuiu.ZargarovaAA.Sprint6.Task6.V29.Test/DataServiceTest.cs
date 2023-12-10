﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZargarovAA.Sprint6.Task6.V29.Lib;

namespace Tyuiu.ZargarovAA.Sprint6.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V29.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = " gMxrJi rvzAEwiXzIsLRa xakZKciG";
            Assert.AreEqual(wait, res);

        }
    }
}