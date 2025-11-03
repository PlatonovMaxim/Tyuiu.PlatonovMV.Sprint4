using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint4.Task4.V21.Lib;

namespace Tyuiu.PlatonovMV.Sprint4.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            int[,] matrix =
            {
                { 3, 6, 4, 6, 6 },
                { 7, 5, 5, 5, 8 },
                { 3, 8, 6, 7, 7 },
                { 5, 3, 4, 5, 5 },
                { 7, 4, 3, 7, 8 }
            };

            DataService ds = new DataService();
            int res = ds.Calculate(matrix);

            Assert.AreEqual(60, res);
        }
    }
}