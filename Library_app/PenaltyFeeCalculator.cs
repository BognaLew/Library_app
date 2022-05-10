using System;
using System.Collections.Generic;
using System.Text;

namespace Library_app
{
    public class PenaltyFeeCalculator
    {
        List<PenaltyInfo> penalties = new List<PenaltyInfo>();

        /// <summary>
        /// Sets initial list of penalties.
        /// </summary>
        public PenaltyFeeCalculator()
        {
            penalties.Add(new PenaltyInfo("IT", 1, 5));             //IT
            penalties.Add(new PenaltyInfo("History", 2, 3));        //History
            penalties.Add(new PenaltyInfo("Classics", 3, 2));       //Classics
            penalties.Add(new PenaltyInfo("Law", 4, 2));            //Law
            penalties.Add(new PenaltyInfo("Medical", 5, 2));        //Medical
            penalties.Add(new PenaltyInfo("Philosophy", 6, 2));     //Philosophy
        }

        /// <summary>
        /// Gets a PenaltyInfo object that has the id of a bookType equal to the one given.
        /// </summary>
        /// <param name="bookTypeId">id of a book type</param>
        /// <returns></returns>
        public PenaltyInfo GetPenaltyInfo(int bookTypeId)
        {
            return penalties.Find(penalty => penalty.GetBookTypeId() == bookTypeId);
        }

        /// <summary>
        /// Calculates penalty fee taht a borrower has to pay.
        /// </summary>
        /// <param name="numberOfDays">number of days book was borrowed</param>
        /// <param name="bookTypeId">id of a book type</param>
        /// <returns></returns>
        public int CalculatePenaltyFee(int numberOfDays, int bookTypeId)
        {
            if(numberOfDays < 2)
            {
                return 0;
            }
            return (numberOfDays - 1) * GetPenaltyInfo(bookTypeId).GetPenalty();
        }

    }
}
