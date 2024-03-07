using System;
using System.Collections.Generic;

namespace OrderInventory.Models
{
    public partial class Item
    {
        public Item()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
