using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcCurrentValue
{
    class CurrentValueCalculator
    {
        public enum TransactionType
        {
            Buy,
            Sell
        }
        public double GetCurrentValue(double tradeprice, int nominal, TransactionType tp)
        {
            return tp == TransactionType.Buy ? tradeprice * nominal : -1 * tradeprice * nominal;
        }

    }
}
