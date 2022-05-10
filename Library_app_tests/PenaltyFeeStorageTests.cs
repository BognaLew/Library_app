using NUnit.Framework;
using Library_app.PenaltyOperators;


namespace Library_app_tests
{
    class PenaltyFeeStorageTests
    {
        [Test]
        public void SetPenaltyTest()
        {
            PenaltyFeeStorage storage = new PenaltyFeeStorage();
            storage.SetPenalty(1, 9);
            Assert.AreEqual(9, storage.GetPenaltyInfo(1).GetPenalty());
        }

        [Test]
        public void AddPenaltyTest()
        {
            PenaltyFeeStorage storage = new PenaltyFeeStorage();
            storage.AddPenalty("Fantasy", 9);
            Assert.AreEqual(9, storage.GetPenaltyInfo(7).GetPenalty());
        }
    }
}
