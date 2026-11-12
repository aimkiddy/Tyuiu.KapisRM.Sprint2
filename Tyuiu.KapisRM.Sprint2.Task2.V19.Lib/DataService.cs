using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KapisRM.Sprint2.Task2.V19.Lib

{
    public class DataService : ISprint2Task3V19
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                if (x < 12)
                {
                    y = x + Math.Pow((1.0 / x), 2);
                }
                else
                {
                    y = x - Math.Sin(x * x) / x;
                }
            }
            else
            {
                if (x == -22)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Pow(x, 3) - 3;
                }
            }

            return Math.Round(y, 3);
        }
    }
}