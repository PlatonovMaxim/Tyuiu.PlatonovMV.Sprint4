using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint4.Task5.V10.Lib;

namespace Tyuiu.PlatonovMV.Sprint4.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            int[,] matrix =
            {
                { -3, 4, 0, 2, -1 },
                { 5, -4, 3, 6, 7 },
                { -2, 5, 1, -3, 0 },
                { 4, -1, 6, 2, -4 },
                { 0, 3, -2, 7, 1 }
            };

            DataService ds = new DataService();
            int res = ds.Calculate(matrix);

            Assert.AreEqual(56, res);
        }
    }
}