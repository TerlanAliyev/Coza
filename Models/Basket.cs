﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Coza.Models
{
    public partial class Basket
    {
        public int BasketId { get; set; }
        public int? BasketProductId { get; set; }
        public int? BasketUserId { get; set; }

        public virtual Product BasketProduct { get; set; }
        public virtual User BasketUser { get; set; }
    }
}
