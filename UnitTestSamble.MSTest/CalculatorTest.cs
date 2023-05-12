using UnitTestSample.Classes;

namespace UnitTestSamble.MSTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CalculatorNewTest()
        {
            var calculator = new Calculator();
            Assert.IsNotNull(calculator);
        }

        [TestMethod]
        public void CalculatorAddTest() 
        {
            var calculator = new Calculator();
            double result = calculator.Add(1, 1);
            Assert.AreEqual(2, result);
        }
    }
}
