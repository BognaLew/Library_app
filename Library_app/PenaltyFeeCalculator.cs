﻿
namespace Library_app
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
        public int CalculatePenaltyFee(int numberOfDays, int bookTypeId)
        {
            if(numberOfDays < 2)
            {
                return 0;
            }
            return (numberOfDays - 1) * storage.GetPenaltyInfo(bookTypeId).GetPenalty();
        }
    }
}
