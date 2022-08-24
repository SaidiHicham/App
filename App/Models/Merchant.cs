using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Merchant
    {
        public Merchant()
        {
            Orders = new HashSet<Order>();
        }

        public int MerchantId { get; set; }
        public string MerchantName { get; set; } = null!;
        public int MerchantType { get; set; }
        public int MerchantCompany { get; set; }
        public string MerchantUsername { get; set; } = null!;
        public int MerchantAccount { get; set; }
        public int MerchantContact { get; set; }

        public virtual Account MerchantAccountNavigation { get; set; } = null!;
        public virtual Contact MerchantContactNavigation { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
