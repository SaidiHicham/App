using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Lc
    {
        public Lc()
        {
            Accounts = new HashSet<Account>();
        }

        public int LcId { get; set; }
        public string LcName { get; set; } = null!;
        public string LcSerie { get; set; } = null!;
        public int LcContact { get; set; }

        public virtual Contact LcContactNavigation { get; set; } = null!;
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
