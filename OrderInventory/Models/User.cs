using System;
using System.Collections.Generic;

namespace OrderInventory.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public string? UserName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
