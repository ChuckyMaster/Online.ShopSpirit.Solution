using System;
using System.Collections.Generic;

namespace Api.ShopSpirit.Data.Entity.Entities
{
    public partial class Order
    {
        public int OrdersId { get; set; }
        public decimal? Price { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CartId { get; set; }
        public int StateId { get; set; }

        public virtual Cart Cart { get; set; } = null!;
        public virtual State State { get; set; } = null!;
    }
}
