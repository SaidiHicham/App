using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string CustomerFirstname { get; set; } = null!;
        public string CustomerFamilyname { get; set; } = null!;
        public string CustomerUsername { get; set; } = null!;
        public int CustomerContact { get; set; }
        public int CustomerAccount { get; set; }

        public virtual Contact CustomerAccount1 { get; set; } = null!;
        public virtual Account CustomerAccountNavigation { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
