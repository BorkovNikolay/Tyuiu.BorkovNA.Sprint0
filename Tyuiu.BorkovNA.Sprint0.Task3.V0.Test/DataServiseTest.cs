using Tyuiu.BorkovNA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.BorkovNA.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}