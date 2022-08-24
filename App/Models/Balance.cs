using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Balance
    {
        public int BalanceId { get; set; }
        public double BalanceMoney { get; set; }
        public int BalanceAccount { get; set; }

        public virtual Account BalanceAccountNavigation { get; set; } = null!;
    }
}
