using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcCurrentValue
{
    class CalcCurrentValue
    {
        public enum TransactionType
        {
            Buy,
            Sell
        }

        public double CalcCV(double tradeprice, int nominal, TransactionType tp)
        {
             
            return tp == TransactionType.Buy ? tradeprice * nominal : -1 * tradeprice * nominal;
        }

    }
}
