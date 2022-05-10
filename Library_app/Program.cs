using System;
using Library_app.ConsoleOperators;
using Library_app.PenaltyOperators;

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

            PenaltyFeeCalculator calculator = new PenaltyFeeCalculator(storage);

            while (true)
            {
                reader.ReadFromConsole(borrowInfo);
                writer.WriteOnConsole(calculator.CalculatePenaltyFee(borrowInfo));
                Console.WriteLine("End program? [y/N]");
                string ans = Console.ReadLine();
                if (ans.ToLower().Equals("y"))
                {
                    break;
                }
            }
        }
    }
}
