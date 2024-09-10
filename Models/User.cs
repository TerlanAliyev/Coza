using System;
using System.Collections.Generic;

#nullable disable

namespace Coza.Models
{
    public partial class User
    {
        public User()
        {
            Baskets = new HashSet<Basket>();
            Favorites = new HashSet<Favorite>();
            Products = new HashSet<Product>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserNickName { get; set; }
        public string UserPassword { get; set; }
        public string UserProfilePhoto { get; set; }
        public string UserGender { get; set; }

        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
