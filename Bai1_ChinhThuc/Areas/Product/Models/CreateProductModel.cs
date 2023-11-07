using Bai1_ChinhThuc.Model.Blog;
using Bai1_ChinhThuc.Model.Product;
using System.ComponentModel.DataAnnotations;

namespace Bai1_ChinhThuc.Areas.Product.Models
{
    public class CreateProductModel : ProductModel
    {
        [Display(Name = "Danh mục sản phẩm")]
        public int[] CategoryProductIds { get; set; }
    }
}
