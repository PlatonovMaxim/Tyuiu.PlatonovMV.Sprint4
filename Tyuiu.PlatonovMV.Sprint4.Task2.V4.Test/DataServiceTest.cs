using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint4.Task2.V4.Lib;

namespace Tyuiu.PlatonovMV.Sprint4.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            int[] array = { 2, 3, 9, 6, 5, 8, 7, 4, 9, 2, 5, 3, 7 };
            DataService ds = new DataService();

            int res = ds.Calculate(array);

            Assert.AreEqual(48, res);
        }
    }
}