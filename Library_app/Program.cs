using System;

namespace Library_app
{
    class Program
    {
        static void Main(string[] args)
        {
            PenaltyFeeCalculator calculator = new PenaltyFeeCalculator();
            Console.WriteLine(calculator.CalculatePenaltyFee(2, 1));
        }
    }
}
