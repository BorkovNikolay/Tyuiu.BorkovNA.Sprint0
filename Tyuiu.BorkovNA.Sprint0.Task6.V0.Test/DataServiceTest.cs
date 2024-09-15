using Tyuiu.BorkovNA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.BorkovNA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionArrayValid()
        {
            var numbers = new int[] {1,2,3,4,5};
            var res = DataServise.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        public void CheckedSubtractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataServise.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);
        }

        public void CheckedMultArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataServise.MultArray(numbers);
            Assert.AreEqual(120, res);
 
        }

    }
}