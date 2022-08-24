using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Contact
    {
        public Contact()
        {
            Customers = new HashSet<Customer>();
            Lcs = new HashSet<Lc>();
            Merchants = new HashSet<Merchant>();
        }

        public int ContactId { get; set; }
        public string ContactPhone { get; set; } = null!;
        public string ContactMobile1 { get; set; } = null!;
        public string ContactMobile2 { get; set; } = null!;
        public string ContactEmail { get; set; } = null!;
        public int ContactCustomer { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Lc> Lcs { get; set; }
        public virtual ICollection<Merchant> Merchants { get; set; }
    }
}
