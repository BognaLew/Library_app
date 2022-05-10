using System;
using System.Collections.Generic;

namespace Library_app
{
    public class PenaltyFeeStorage
    {
        List<PenaltyInfo> penalties = new List<PenaltyInfo>();

        /// <summary>
        /// Sets initial list of penalties.
        /// </summary>
        public PenaltyFeeStorage()
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
        /// <param name="bookTypeId">Id of a book type.</param>
        /// <returns></returns>
        public virtual PenaltyInfo GetPenaltyInfo(int bookTypeId)
        {
            return penalties.Find(penalty => penalty.GetBookTypeId() == bookTypeId);
        }

        /// <summary>
        /// Gets number of elements from list of penalties.
        /// </summary>
        /// <returns>Number of penalties.</returns>
        public int GetNumberOfPenalties()
        {
            return penalties.Count;
        }

        /// <summary>
        /// Sets penalty of an existing PenaltyInfo.
        /// </summary>
        /// <param name="bookTypeId">Id of a book type.</param>
        /// <param name="penalty">New penalty to be set.</param>
        public void SetPenalty(int bookTypeId, int penalty)
        {
            if (bookTypeId <= GetNumberOfPenalties() && bookTypeId > 0)
            {
                GetPenaltyInfo(bookTypeId).SetPenalty(penalty);
            }
            else
            {
                Console.WriteLine("Given id is out of domain.");
            }
        }

        public void AddPenalty(string bookTypeName, int penalty)
        {
            penalties.Add(new PenaltyInfo(bookTypeName, penalties.Count + 1, penalty));
        }

        /// <summary>
        /// Prints info about all penalties
        /// </summary>
        public void PrintPenalties()
        {
            foreach (PenaltyInfo p in penalties)
            {
                p.PrintPenaltyInfo();
            }
            Console.WriteLine();
        }

    }
}
