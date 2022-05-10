using System;
using System.Collections.Generic;
using System.Text;

namespace Library_app.PenaltyOperators
{
    public class PenaltyInfo
    {
        private string bookTypeName;
        private int bookTypeId;
        private int penalty;

        /// <summary>
        /// Sets initial book type, id of a book and penalty fee per day.
        /// </summary>
        /// <param name="bookType">book type</param>
        /// <param name="bookId">id of a book type</param>
        /// <param name="penalty">penalty per day</param>
        public PenaltyInfo(string bookTypeName, int bookTypeId, int penalty)
        {
            this.bookTypeName = bookTypeName;
            this.bookTypeId = bookTypeId;
            this.penalty = penalty;
        }

        /// <summary>
        /// Gets penalty fee per day.
        /// </summary>
        /// <returns>penalty per day</returns>
        public virtual int GetPenalty()
        {
            return penalty;
        }

        /// <summary>
        /// Gets id of a book type.
        /// </summary>
        /// <returns>id of a book type</returns>
        public int GetBookTypeId()
        {
            return bookTypeId;
        }

        /// <summary>
        /// Sets penalty fee per day.
        /// </summary>
        /// <param name="penalty">penalty per day</param>
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
