using NUnit.Framework;
using Library_app.PenaltyOperators;

namespace Library_app_tests
{
    public class PenaltyInfoTests
    {
        [Test]
        public void SetPenaltyTest()
        {
            PenaltyInfo penaltyInfo = new PenaltyInfo("IT", 1, 5);
            penaltyInfo.SetPenalty(9);
            Assert.AreEqual(9, penaltyInfo.GetPenalty());
        }
    }
}
