using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcCurrentValue
{
    class CalcPL
    {
        public CalcPL()
        {

        }
        public CalcPL(double tradeprice, double originalprice, int nominal)
        {
            TradePrice = tradeprice;
            OriginalPrice = originalprice;
            Nominal = nominal;
        }
        public double TradePrice { get; set; }
        public double OriginalPrice { get; set; }
        public int Nominal { get; private set; }

        public double PL() => (TradePrice - OriginalPrice) * Nominal;

    }
}
