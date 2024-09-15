using Tyuiu.BorkovNA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BorkovNA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Николай";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Николай", res);
        }
    }
}