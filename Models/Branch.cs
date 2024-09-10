using System;
using System.Collections.Generic;

#nullable disable

namespace Coza.Models
{
    public partial class Branch
    {
        public Branch()
        {
            Products = new HashSet<Product>();
        }

        public int BranchId { get; set; }
        public string BranchName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
