using System;
using System.Collections.Generic;

namespace Api.ShopSpirit.Data.Entity.Entities
{
    public partial class User
    {
        public User()
        {
            Addresses = new HashSet<Address>();
        }

        public int UserId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual Cart? Cart { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
