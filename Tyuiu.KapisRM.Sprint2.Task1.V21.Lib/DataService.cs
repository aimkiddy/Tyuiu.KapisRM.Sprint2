using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KapisRM.Sprint2.Task1.V21.Lib
{
    public class DataService : ISprint2Task1V21
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) & (c < d);          
            res[1] = (a != c) | (b <= a);         
            res[2] = (a < c) && (d > b);          
            res[3] = (a > b) || (c < d);         
            res[4] = (a == c) || (d < b);         
            res[5] = !(a < b);                    

            return res;
        }
    }
}