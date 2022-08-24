using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Account
    {
        public Account()
        {
            Customers = new HashSet<Customer>();
            Merchants = new HashSet<Merchant>();
            Notifications = new HashSet<Notification>();
        }

        public int AccountId { get; set; }
        public string AccountUsername { get; set; } = null!;
        public string AccountPass { get; set; } = null!;
        public string AccountPassalt { get; set; } = null!;
        public int AccountLc { get; set; }

        public virtual Lc AccountLcNavigation { get; set; } = null!;
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Merchant> Merchants { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
