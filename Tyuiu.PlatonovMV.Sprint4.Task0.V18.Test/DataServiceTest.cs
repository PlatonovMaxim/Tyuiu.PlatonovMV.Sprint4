using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint4.Task0.V18.Lib;

namespace Tyuiu.PlatonovMV.Sprint4.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumOddArrEl()
        {
            int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            DataService ds = new DataService();

            int res = ds.GetSumOddArrEl(array);

            Assert.AreEqual(41, res);
        }
    }
}