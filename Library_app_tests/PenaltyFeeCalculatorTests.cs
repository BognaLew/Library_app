using NUnit.Framework;
using Library_app;

namespace Library_app_tests
{
    public class PenaltyFeeCalculatorTests
    {
        [Test]
        public void CalculatePenaltyTest()
        {

            PenaltyFeeCalculator calculator = new PenaltyFeeCalculator();
            var result = calculator.CalculatePenaltyFee(2, 1);
            Assert.AreEqual(5, result);
        }
    }
}