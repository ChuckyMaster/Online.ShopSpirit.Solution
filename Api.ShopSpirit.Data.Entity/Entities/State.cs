using System;
using System.Collections.Generic;

namespace Api.ShopSpirit.Data.Entity.Entities
{
    public partial class State
    {
        public State()
        {
            Orders = new HashSet<Order>();
        }

        public int StateId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
