using System;

namespace Library_app
{
    class ConsoleReader
    {
        PenaltyFeeStorage storage;

        /// <summary>
        /// Initialize penalty storage.
        /// </summary>
        /// <param name="storage">Penalty storage.</param>
        public ConsoleReader(PenaltyFeeStorage storage)
        {
            this.storage = storage;
        }

        /// <summary>
        /// Reads and parse id of a book type.
        /// </summary>
        /// <returns>Id of a book type.</returns>
        public int ReadBookTypeId()
        {
            int bookTypeId;
            while (true)
            {
                Console.Write("Please pick a book category");
                storage.PrintPenalties();
                if (!int.TryParse(Console.ReadLine(), out bookTypeId))
                {
                    Console.WriteLine("Cannot parse integer, please try again.");
                }
                else if (bookTypeId > 0 && bookTypeId <= storage.GetNumberOfPenalties())
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Integer out of domain, please try again");
                }
            }
            return bookTypeId;
        }

        /// <summary>
        /// Reads and parse date from console.
        /// </summary>
        /// <param name="action">Action to be displayed.</param>
        /// <returns>Parsed date.</returns>
        public DateTime ReadDate(string action)
        {
            string tmp;
            DateTime date;
            while (true)
            {
                Console.WriteLine($"Please write the day, month, year of the {action}");
                tmp = Console.ReadLine();
                if (!DateTime.TryParse(tmp, out date))
                {
                    Console.WriteLine("Cannot parse date, please try again.");
                }
                else
                {
                    break;
                }
            }
            return date;
        }

        /// <summary>
        /// Reads input about borrowed book.
        /// </summary>
        public void ReadFromConsole()
        {
            int bookTypeId = ReadBookTypeId();
            DateTime borrowDate = ReadDate("borrow");
            DateTime returnDate = ReadDate("return");

            int numberOfDays;
            if (int.TryParse(returnDate.Subtract(borrowDate).Days.ToString(), out numberOfDays))
            {
                Console.WriteLine($"Days = {numberOfDays}, book id = {bookTypeId}");
            }
        }
    }
}
