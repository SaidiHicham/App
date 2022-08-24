using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class File
    {
        public int FilesId { get; set; }
        public string FilesName { get; set; } = null!;
        public string FilesDesc { get; set; } = null!;
        public string FilesPath { get; set; } = null!;
        public int FilesAccount { get; set; }

        public virtual Account FilesAccountNavigation { get; set; } = null!;
    }
}
