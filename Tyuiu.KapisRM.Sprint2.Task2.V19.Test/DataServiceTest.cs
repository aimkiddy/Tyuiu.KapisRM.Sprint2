using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint2.Task2.V19.Lib;

namespace Tyuiu.KapisRM.Sprint2.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;

            double res = ds.Calculate(x);
            Assert.IsNotNull(res);
        }
    }
}