using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint4.Task1.V18.Lib;

namespace Tyuiu.PlatonovMV.Sprint4.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            int[] array = { 7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7 };
            DataService ds = new DataService();

            int res = ds.Calculate(array);

            Assert.AreEqual(79, res);
        }
    }
}