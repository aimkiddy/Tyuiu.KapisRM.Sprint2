using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint2.Task3.V1.Lib;

namespace Tyuiu.KapisRM.Sprint2.Task3.Test
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
            double wait = 9.5;

            Assert.AreEqual(wait, res);
        }
    }
}