using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint4.Task3.V19.Lib;

namespace Tyuiu.PlatonovMV.Sprint4.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            int[,] array = {
                { 6, 6, 5, 8, 3 },
                { 9, 4, 4, 3, 4 },
                { 3, 8, 8, 6, 4 },
                { 6, 6, 3, 3, 6 },
                { 9, 8, 5, 3, 7 }
            };

            DataService ds = new DataService();
            int res = ds.Calculate(array);

            Assert.AreEqual(14, res);
        }
    }
}