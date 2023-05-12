using UnitTestSample.Classes;

namespace CodeFromTest
{
    public class MathCalculator
    {
        public MathCalculator()
        {
        }

        public double Power(int baseNumber, int exponent)
        {
            Calculator calculator = new Calculator();
            // if the exponent is 0, return 1, since any number raised to the 0th power is 1
            if (exponent == 0)
            {
                return 1;
            }
            // if the exponent is negative, recursively calculate the result of the positive exponent and return its reciprocal
            else if (exponent < 0)
            {
                return 1 / Power(baseNumber, -exponent);
            }
            // if the exponent is even, recursively calculate the result of raising the base to half of the exponent, and square the result
            else if (exponent % 2 == 0)
            {
                double temp = Power(baseNumber, exponent / 2);
                return calculator.Multiply(temp, temp); // the result is the square of the result of raising the base to half the exponent
            }
            // if the exponent is odd and not 1, recursively calculate the result of raising the base to the exponent minus 1, and multiply by the base
            else
            {
                return baseNumber * Power(baseNumber, exponent - 1);
            }
        }
    }
}