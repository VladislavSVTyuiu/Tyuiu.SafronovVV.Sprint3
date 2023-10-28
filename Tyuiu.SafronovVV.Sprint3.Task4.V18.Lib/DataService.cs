using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SafronovVV.Sprint3.Task4.V18.Lib
{
    public class DataService : ISprint3Task4V18
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int x = startValue; x < stopValue; x++)
            {
                if (x == 0)
                    break;
                else
                    res += Math.Sin(x) / Math.Cos(x);
            }
            return Math.Round(res, 3);
        }
    }
}
