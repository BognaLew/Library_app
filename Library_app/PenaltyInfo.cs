﻿using System;

namespace Library_app
{
    public class PenaltyInfo
    {
        private string bookTypeName;
        private int bookTypeId;
        private int penalty;

        /// <summary>
        /// Sets initial book type, id of a book and penalty fee per day.
        /// </summary>
        /// <param name="bookType">Book type.</param>
        /// <param name="bookId">Id of a book type.</param>
        /// <param name="penalty">Penalty per day.</param>
        public PenaltyInfo(string bookTypeName, int bookTypeId, int penalty)
        {
            this.bookTypeName = bookTypeName;
            this.bookTypeId = bookTypeId;
            this.penalty = penalty;
        }

        /// <summary>
        /// Gets penalty fee per day.
        /// </summary>
        /// <returns>Penalty per day.</returns>
        public virtual int GetPenalty()
        {
            return penalty;
        }

        /// <summary>
        /// Gets id of a book type.
        /// </summary>
        /// <returns>Id of a book type.</returns>
        public int GetBookTypeId()
        {
            return bookTypeId;
        }

        /// <summary>
        /// Sets penalty fee per day.
        /// </summary>
        /// <param name="penalty">Penalty per day.</param>
        public void SetPenalty(int penalty)
        {
            this.penalty = penalty;
        }

        /// <summary>
        /// Prints id and name of a book type.
        /// </summary>
        public void PrintPenaltyInfo()
        {
            Console.Write($" [{bookTypeId}] {bookTypeName}");
        }
    }
}
