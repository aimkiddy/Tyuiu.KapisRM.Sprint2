using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KapisRM.Sprint2.Task2.V19.Lib

{
    public class DataService : ISprint2Task2V19
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
           
            bool res = false;

            if (x >= 2 && x <= 6)
            {
                if (y >= 3 && y <= 7)
                {
                    res = true;
                }
            }
            if (x >= 2 && x <= 3)
            {
                if (y >= 8 && y <= 11)
                {
                    res = true;
                }
            }
            if (x >= 9 && x <= 12)
            {
                if (y >= 3 && y <= 4)
                {
                    res = true;
                }
            }
            if (x >= 6 && x <= 11)
            {
                if (y >= 6 && y <= 7)
                {
                    res = true;
                }
            }
            if (x >= 10 && x <= 11)
            {
                if (y >= 8 && y <= 11)
                {
                    res = true;
                }
            }
            if (x >= 7 && x <= 11)
            {
                if (y >= 11 && y <= 13)
                {
                    res = true;
                }
            }
            if (x >= 9 && x <= 13)
            {
                if (y >= 14 && y <= 14)
                {
                    res = true;
                }
            }

            return res;
        }
    }
}