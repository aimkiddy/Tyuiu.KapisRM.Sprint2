using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint2.Task0.V10.Lib;

namespace Tyuiu.KapisRM.Sprint2.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1305;
            int y = 475;

            bool[] wait = { false, true, false, true, false, true };
            bool[] res = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}