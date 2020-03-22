using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy2Utest
{
    public class Transaction
    {
        public double ExchangeRate { get; set; }
        public decimal ConvertedMoney { get; set; }
        public string Currency { get; set; }
        public DateTime Date { get; set; }
    }
}
