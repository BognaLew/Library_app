using System;

namespace Library_app
{
    class Program
    {
        static void Main(string[] args)
        {
            PenaltyFeeStorage storage = new PenaltyFeeStorage();
            PenaltyFeeCalculator calculator = new PenaltyFeeCalculator(storage);
            Console.WriteLine(calculator.CalculatePenaltyFee(2, 1));

            ConsoleReader reader = new ConsoleReader(storage);
            reader.ReadFromConsole();
        }
    }
}
