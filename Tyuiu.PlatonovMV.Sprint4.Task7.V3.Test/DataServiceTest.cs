using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint4.Task7.V3.Lib;

namespace Tyuiu.PlatonovMV.Sprint4.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            string value = "27182818";
            int res = ds.Calculate(4, 2, value);
            Assert.AreEqual(3, res);  
        }
    }
}