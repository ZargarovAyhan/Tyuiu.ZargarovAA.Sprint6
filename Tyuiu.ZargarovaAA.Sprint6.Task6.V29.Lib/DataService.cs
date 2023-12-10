﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.ZargarovAA.Sprint6.Task6.V29.Lib
{
    public class DataService : ISprint6Task6V29
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            char ch = 'i';



            string[] words = File.ReadAllText(path).Split(' ');
            foreach (string word in words)
            {
                if (word.Contains(ch))
                {
                    resStr += " " + word;
                }
            }

            return resStr;
        }
    }
}