using NUnit.Framework;
using Moq;
using Library_app;
using Library_app.PenaltyOperators;

namespace Library_app_tests
{
    public class PenaltyFeeCalculatorTests
    {
        [Test]
        public void CalculatePenaltyTest()
        {
            var borrowInfo = new Mock<BorrowInfo>();
            borrowInfo
                .Setup(x => x.GetBookTypeId())
                .Returns(1);
            borrowInfo
                .Setup(x => x.GetNumberOfDays())
                .Returns(3);

            var penaltyInfo = new Mock<PenaltyInfo>("IT", 1, 5);
            penaltyInfo
                .Setup(x => x.GetPenalty())
                .Returns(5);

            var penaltyStorage = new Mock<PenaltyFeeStorage>();
            penaltyStorage
                .Setup(x => x.GetPenaltyInfo(1))
                .Returns(penaltyInfo.Object);

            PenaltyFeeCalculator calculator = new PenaltyFeeCalculator(penaltyStorage.Object);
            var result = calculator.CalculatePenaltyFee(borrowInfo.Object);
            Assert.AreEqual(10, result);
        }
    }
}