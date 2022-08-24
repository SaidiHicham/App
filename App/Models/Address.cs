using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string AddressStreet { get; set; } = null!;
        public string AddressHousenumber { get; set; } = null!;
        public string AddressZipcode { get; set; } = null!;
        public string AddressCity { get; set; } = null!;
        public int AddressContact { get; set; }

        public virtual Contact AddressContactNavigation { get; set; } = null!;
    }
}
