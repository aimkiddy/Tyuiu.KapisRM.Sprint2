using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint2.Task6.V5.Lib;

namespace Tyuiu.KapisRM.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardValue()
        {
            DataService ds = new DataService();

            Assert.AreEqual("шестерка", ds.FindCardValue(6));
            Assert.AreEqual("валет", ds.FindCardValue(11));
            Assert.AreEqual("дама", ds.FindCardValue(12));
            Assert.AreEqual("король", ds.FindCardValue(13));
            Assert.AreEqual("туз", ds.FindCardValue(14));
        }
    }
}