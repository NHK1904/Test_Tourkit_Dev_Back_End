using System;
using System.Collections.Generic;

namespace Test_Tourkit.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        public int ProductCategoryId { get; set; }
        public string ProductCategory1 { get; set; } = null!;
        public DateTime DateAdded { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
