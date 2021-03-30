using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.Common
{
    public class ClientList : List<Client>
    {
        public decimal TotalYTDSales => this.Sum(x => x.YTDSales);
        public int CreditHoldCount => this.Count(x => x.CreditHold == true);

        public decimal AverageYTDSales => TotalYTDSales / this.Count;
    }
}
