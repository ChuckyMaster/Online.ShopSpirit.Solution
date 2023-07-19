using System;
using System.Collections.Generic;

namespace Api.ShopSpirit.Data.Entity.Entities
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string? City { get; set; }
        public string? Zipcode { get; set; }
        public string? Country { get; set; }
        public string? Street { get; set; }
        public string? Number { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
