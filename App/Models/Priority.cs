using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Priority
    {
        public Priority()
        {
            Notifications = new HashSet<Notification>();
        }

        public int PriorityId { get; set; }
        public int PriorityLevel { get; set; }
        public string PriorityLabel { get; set; } = null!;
        public string PriorityIcon { get; set; } = null!;

        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
