using System;
using System.Collections.Generic;

#nullable disable

namespace Coza.Models
{
    public partial class Product
    {
        public Product()
        {
            Baskets = new HashSet<Basket>();
            Favorites = new HashSet<Favorite>();
            Photos = new HashSet<Photo>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescreption { get; set; }
        public string ProductPrice { get; set; }
        public int? ProductBranchId { get; set; }
        public int? ProductColorId { get; set; }
        public int? ProductCategoryId { get; set; }
        public int? ProductUserId { get; set; }

        public virtual Branch ProductBranch { get; set; }
        public virtual Category ProductCategory { get; set; }
        public virtual Color ProductColor { get; set; }
        public virtual User ProductUser { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
