using NUnit.Framework;
using Library_app;
using Moq;

namespace Library_app_tests
{
    public class PenaltyFeeCalculatorTests
    {
        [Test]
        public void CalculatePenaltyTest()
        {
            var penaltyInfo = new Mock<PenaltyInfo>("IT", 1, 5);
            penaltyInfo
                .Setup(x => x.GetPenalty())
                .Returns(5);

            var penaltyStorage = new Mock<PenaltyFeeStorage>();
            penaltyStorage
                .Setup(x => x.GetPenaltyInfo(1))
                .Returns(penaltyInfo.Object);

            PenaltyFeeCalculator calculator = new PenaltyFeeCalculator(penaltyStorage.Object);
            var result = calculator.CalculatePenaltyFee(2, 1);
            Assert.AreEqual(5, result);
        }
    }
}