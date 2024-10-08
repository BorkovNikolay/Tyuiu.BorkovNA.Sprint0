using Tyuiu.BorkovNA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.BorkovNA.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataServise.Addition(5, 5));
        }
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataServise.Subtraction(10, 5));
        }

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataServise.Multiplication(10, 5));
        }

        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataServise.Division(9, 3));
        }

    }
}