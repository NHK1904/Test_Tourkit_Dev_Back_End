using System.ComponentModel.DataAnnotations;

namespace Test_Tourkit.Dto
{
    public class ProductDTO
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }
        public DateTime DateAdded { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductCategory1 { get; set; } = null!;
    }
}
