using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Notification
    {
        public int NotificationId { get; set; }
        public string NotificationLabel { get; set; } = null!;
        public string NotificationDesc { get; set; } = null!;
        public DateTime NotificationDate { get; set; }
        public int NotificationPriority { get; set; }
        public int NotificationAccount { get; set; }

        public virtual Account NotificationAccountNavigation { get; set; } = null!;
        public virtual Priority NotificationPriorityNavigation { get; set; } = null!;
    }
}
