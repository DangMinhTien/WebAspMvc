using Bai1_ChinhThuc.Model.Product;
namespace Bai1_ChinhThuc.Areas.Product.Models
{
    public class CartItem
    {
        public int quantity { set; get; }
        public ProductModel product { set; get; }
    }
}
