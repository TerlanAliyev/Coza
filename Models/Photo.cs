using System;
using System.Collections.Generic;

#nullable disable

namespace Coza.Models
{
    public partial class Photo
    {
        public int PhotoId { get; set; }
        public string PhotoName { get; set; }
        public int? PhotoProductId { get; set; }

        public virtual Product PhotoProduct { get; set; }
    }
}
