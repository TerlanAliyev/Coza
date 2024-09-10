using System;
using System.Collections.Generic;

#nullable disable

namespace Coza.Models
{
    public partial class Favorite
    {
        public int FavoriteId { get; set; }
        public int? FavoriteProductId { get; set; }
        public int? FavoriteUserId { get; set; }

        public virtual Product FavoriteProduct { get; set; }
        public virtual User FavoriteUser { get; set; }
    }
}
