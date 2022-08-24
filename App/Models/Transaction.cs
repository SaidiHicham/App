using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public int TransactionOrder { get; set; }
        public DateTime TransactionDate { get; set; }
        public int TransactionNumber { get; set; }
        public short TransactionState { get; set; }

        public virtual Order TransactionOrderNavigation { get; set; } = null!;
    }
}
