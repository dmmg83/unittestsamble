using CodeFromTest;

namespace UnitTestSamble.MSTest
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void PowerTest()
        { 
            MathCalculator mathCalculator = new MathCalculator();
            double aux = mathCalculator.Power(2, 3);
            Assert.AreEqual(8, aux);
        }      
    }
}
