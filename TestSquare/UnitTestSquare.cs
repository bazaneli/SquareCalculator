using SquareCalc;

namespace TestSquare
{
    [TestClass]
    public class UnitTestSquare
    {
        [TestMethod]
        public void TestSquareRoot()
        {
            // Test the square root of a few different numbers
            Assert.AreEqual(SquareCalculator.SquareRoot(4.0), 2.0, 0.00001);
            Assert.AreEqual(SquareCalculator.SquareRoot(16.0), 4.0, 0.00001);
            Assert.AreEqual(SquareCalculator.SquareRoot(25.0), 5.0, 0.00001);
            Assert.AreEqual(SquareCalculator.SquareRoot(36.0), 6.0, 0.00001);
            Assert.AreEqual(SquareCalculator.SquareRoot(100.0), 10.0, 0.00001);
        }
    }
}