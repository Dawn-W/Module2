using System;
using static CalcCurrentValue.CurrentValueCalculator;

namespace CalcCurrentValue
{
    class Program
    {
        static void Main(string[] args)
        {
            double tradeprice = 67.53d;
            Console.WriteLine($"Current price is {tradeprice}.");
            Console.WriteLine("Input the nominal of the trade: ");
            int nominal = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Transaction Type : Buy / Sell");
            string transactionTpye = Console.ReadLine().Trim();

            TransactionType trcType;
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType),transactionTpye,true);

            var cvCalculator = new CurrentValueCalculator();
            double result = cvCalculator.GetCurrentValue(tradeprice, nominal, trcType);
            Console.WriteLine($"The Current Value is: {result}.");

            if(trcType == TransactionType.Sell)
            {
                Console.WriteLine("Input the original price: ");
                double originalprice = double.Parse(Console.ReadLine());
                var pofitlostfigure = new PofitLossFigureCalculator(tradeprice, originalprice, nominal);
                var plResult = pofitlostfigure.GetPofitLossFigure();
                Console.WriteLine($"The profit loss figure is: {plResult}");
            }
            Console.ReadKey();
        }
    }
}
