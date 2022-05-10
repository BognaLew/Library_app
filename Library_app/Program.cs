using System;

namespace Library_app
{
    class Program
    {
        static void Main(string[] args)
        {
            PenaltyFeeStorage storage = new PenaltyFeeStorage();
            BorrowInfo borrowInfo = new BorrowInfo();

            ConsoleReader reader = new ConsoleReader(storage);
            ConsoleWriter writer = new ConsoleWriter();
            reader.ReadFromConsole(borrowInfo);

            PenaltyFeeCalculator calculator = new PenaltyFeeCalculator(storage);
            writer.WriteOnConsole(calculator.CalculatePenaltyFee(borrowInfo));
        }
    }
}
