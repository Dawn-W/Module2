using System;
using static CalcCurrentValue.CalcCurrentValue;

namespace CalcCurrentValue
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 67.53d;
            Console.WriteLine($"Current price is {price}.");
            Console.WriteLine("Input the nominal of the trade: ");
            int nominal = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Transaction Type : Buy / Sell");
            string transactionTpye = Console.ReadLine().Trim();

            TransactionType trcType;
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType),transactionTpye,true);

            var ccv = new CalcCurrentValue();
            double result = ccv.CalcCV(price, nominal, trcType);
            Console.WriteLine($"The Current Value is: {result}.");
            Console.ReadKey();
        }
    }
}
