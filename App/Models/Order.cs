using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Order
    {
        public Order()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderMerchant { get; set; }
        public int OrderCostumer { get; set; }
        public int OrderGoods { get; set; }
        public double Rest { get; set; }

        public virtual Customer OrderCostumerNavigation { get; set; } = null!;
        public virtual Good OrderGoodsNavigation { get; set; } = null!;
        public virtual Merchant OrderMerchantNavigation { get; set; } = null!;
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
