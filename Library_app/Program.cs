using System;

namespace Library_app
{
    class Program
    {
        static void Main(string[] args)
        {
            PenaltyFeeStorage storage = new PenaltyFeeStorage();

            ConsoleReader reader = new ConsoleReader(storage);
            ConsoleWriter writer = new ConsoleWriter();
            reader.ReadFromConsole();

            PenaltyFeeCalculator calculator = new PenaltyFeeCalculator(storage);
            writer.WriteOnConsole(calculator.CalculatePenaltyFee(2, 1));
        }
    }
}
