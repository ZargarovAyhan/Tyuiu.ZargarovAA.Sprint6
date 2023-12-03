using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZargarovAA.Sprint6.Task0.V19.Lib

{
    public class DataService : ISprint6Task0V19
    {
        public double Calculate(int x)
        {
            double res = -0.25 * ((double)x * (double)x * (double)x - 3 * (double)x * (double)x + 4);
            return Math.Round(res, 3);
        }
    }
}
