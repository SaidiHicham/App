using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Good
    {
        public Good()
        {
            Orders = new HashSet<Order>();
        }

        public int GoodsId { get; set; }
        public int GoodsNumber { get; set; }
        public string GoodsName { get; set; } = null!;
        public double GoodsPrice { get; set; }
        public int GoodsMerchant { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
