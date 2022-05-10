
namespace Library_app.PenaltyOperators
{
    public class PenaltyFeeCalculator
    {
        private PenaltyFeeStorage storage;

        /// <summary>
        /// Sets initial storage of penalties.
        /// </summary>
        /// <param name="storage">Storage of penalties</param>
        public PenaltyFeeCalculator(PenaltyFeeStorage storage)
        {
            this.storage = storage;
        }

        /// <summary>
        /// Calculates penalty fee taht a borrower has to pay.
        /// </summary>
        /// <param name="numberOfDays">Number of days book was borrowed.</param>
        /// <param name="bookTypeId">Id of a book type.</param>
        /// <returns>Calculated penalty fee.</returns>
        public int CalculatePenaltyFee(BorrowInfo borrowInfo)
        {
            if(borrowInfo.GetNumberOfDays() < 2)
            {
                return 0;
            }
            return (borrowInfo.GetNumberOfDays() - 1) * storage.GetPenaltyInfo(borrowInfo.GetBookTypeId()).GetPenalty();
        }
    }
}
