using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint4.Task6.V28.Lib;

namespace Tyuiu.PlatonovMV.Sprint4.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            string[] array = { "Река", "Озеро", "Болото", "Овчар", "Луна", "Море" };
            DataService ds = new DataService();

            string[] res = ds.Calculate(array);
            string[] wait = { "Река", "Луна", "Море" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}