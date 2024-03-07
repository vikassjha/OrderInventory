using System;
using System.Collections.Generic;

namespace OrderInventory.Models
{
    public partial class Category
    {
        public Category()
        {
            Items = new HashSet<Item>();
        }

        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
