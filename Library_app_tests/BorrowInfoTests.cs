using NUnit.Framework;
using Library_app;

namespace Library_app_tests
{
    public class BorrowInfoTests
    {
        [Test]
        public void SetNumberOfDaysTest()
        {
            BorrowInfo borrowInfo = new BorrowInfo();
            borrowInfo.SetNumberOfDays(9);
            Assert.AreEqual(9, borrowInfo.GetNumberOfDays());
        }

        [Test]
        public void SetBookTypeIdTest()
        {
            BorrowInfo borrowInfo = new BorrowInfo();
            borrowInfo.SetBookTypeId(5);
            Assert.AreEqual(5, borrowInfo.GetBookTypeId());
        }
    }
}
