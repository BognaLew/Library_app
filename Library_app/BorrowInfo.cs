
namespace Library_app
{
    public class BorrowInfo
    {
        private int numberOfDays;
        private int bookTypeId;

        /// <summary>
        /// Gets number of days the book was borrowed.
        /// </summary>
        /// <returns>Number of days.</returns>
        public virtual int GetNumberOfDays()
        {
            return numberOfDays;
        }

        /// <summary>
        /// Gets id of a type of borrowed book.
        /// </summary>
        /// <returns>Book type id.</returns>
        public virtual int GetBookTypeId()
        {
            return bookTypeId;
        }

        /// <summary>
        /// Sets number of days the book was borrowed.
        /// </summary>
        /// <param name="numberOfDays">Number of days.</param>
        public void SetNumberOfDays(int numberOfDays)
        {
            this.numberOfDays = numberOfDays;
        }

        /// <summary>
        /// Sets id of a type of borrowed book.
        /// </summary>
        /// <param name="bookId">Id of a book type.</param>
        public void SetBookTypeId(int bookTypeId)
        {
            this.bookTypeId = bookTypeId;
        }
    }
}
