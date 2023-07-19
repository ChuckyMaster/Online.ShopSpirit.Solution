using System;
using System.Collections.Generic;

namespace Api.ShopSpirit.Data.Entity.Entities
{
    public partial class Cart
    {
        public Cart()
        {
            CartLines = new HashSet<CartLine>();
        }

        public int CartId { get; set; }
        public decimal? TotalPrice { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Order? Order { get; set; }
        public virtual ICollection<CartLine> CartLines { get; set; }
    }
}
