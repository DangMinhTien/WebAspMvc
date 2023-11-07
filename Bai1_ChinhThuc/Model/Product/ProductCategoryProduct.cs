using System.ComponentModel.DataAnnotations.Schema;

namespace Bai1_ChinhThuc.Model.Product
{
    [Table("ProductCategoryProduct")]
    public class ProductCategoryProduct
    {
        public int ProductId { get; set; }
        public int CategoryProductId { get; set; }
        [ForeignKey("ProductId")]
        public ProductModel Product { get; set; }
        [ForeignKey("CategoryProductId")]
        public CategoryProduct CategoryProduct { get; set; }
    }
}
