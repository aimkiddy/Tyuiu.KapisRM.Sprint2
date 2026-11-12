using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KapisRM.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            
            if (y <= 1)
            {
                if (x <= 0)
                {
                    return (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1);
                }
                else
                {
                    return (y >= x - 1) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1 || y <= 1);
                }
            }
            return false;
        }
    }
}
