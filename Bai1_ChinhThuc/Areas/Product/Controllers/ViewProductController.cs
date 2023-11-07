using Bai1_ChinhThuc.Helper;
using Bai1_ChinhThuc.Model;
using Bai1_ChinhThuc.Model.Product;
using Bai1_ChinhThuc.Model.Blog;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using Bai1_ChinhThuc.Areas.Product.Service;
using Bai1_ChinhThuc.Areas.Product.Models;

namespace Bai1_ChinhThuc.Areas.Product.Controllers
{
    [Area("Product")]
    public class ViewProductController : Controller
    {
        private readonly ILogger<ViewProductController> _logger;
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly CartService _cartService;
        public ViewProductController(
            ILogger<ViewProductController> logger, 
            AppDbContext context,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            CartService cartService)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _cartService = cartService;
        }
        public int pagesize { get; set; } = 10;
        [Route("/product/{categoriesSlug?}")]
        public IActionResult Index(string categoriesSlug,[FromQuery(Name = "p")] int? currentpage)
        {
            var categories = GetCategories();
            ViewBag.categories = categories;
            ViewBag.categoriesSlug = categoriesSlug;
            CategoryProduct Category = null;
            if(!string.IsNullOrEmpty(categoriesSlug)) 
            {
                Category = _context.CategoryProducts.Include(c => c.CategoryChildren)
                                              .FirstOrDefault(c => c.Slug == categoriesSlug);
                if(Category == null)
                {
                    return NotFound("không thấy category");
                }
            }
            ViewBag.category = Category;
            var products = _context.Products
                                .Include(p => p.Photos)
                                .Include(p => p.ProductCategoryProducts)
                                .ThenInclude(pc => pc.CategoryProduct)
                                .ToList();
            products.OrderByDescending(p => p.DateUpdated);
            if(Category != null)
            {
                List<int> IdCate = new List<int>();
                Category.GetChildCategies(null,IdCate);
                IdCate.Add(Category.Id);
                products = products.Where(p => p.ProductCategoryProducts.Where(pc => IdCate.Contains(pc.CategoryProductId)).Any()).ToList();

            }
            // bắt đầu phân trang
            int total = products.Count();
            int totalPages = (int)Math.Ceiling((double)total / pagesize);
            if (currentpage == null) currentpage = 1;
            if (currentpage < 1)
                currentpage = 1;
            if (currentpage > totalPages)
                currentpage = totalPages;
            var pagingmodel = new PagingModel()
            {
                countPage = totalPages,
                currentPage = (int)currentpage,
                generateUrl = (p) => Url.Action("Index", "ViewProduct", new { area = "Product", p = p })
            };
            ViewBag.pagingmodel = pagingmodel;
            ViewBag.totalPost = total;
            ViewBag.PageIndex = ((currentpage - 1) * pagesize) + 1;
            var productInpage = products.Skip((int)(currentpage - 1) * pagesize)
                        .Take(pagesize)
                        .ToList();
            //kết thúc phân trang

            return View(productInpage);
        }
        [Route("/product/{productSlug}.html")]
        public IActionResult Details(string productSlug)
        {
            var categories = GetCategories();
            ViewBag.categories = categories;

            var product = _context.Products
                                .Include(p => p.Photos)
                                .Include(p => p.ProductCategoryProducts)
                                .ThenInclude(pc => pc.CategoryProduct)
                                .FirstOrDefault(p => p.Slug == productSlug);
            if(product == null)
            {
                return NotFound();
            }
            CategoryProduct category = product.ProductCategoryProducts.FirstOrDefault()?.CategoryProduct;
            ViewBag.category = category;
            var lstproduct = _context.Products.Include(p => p.ProductCategoryProducts).ToList();
            var otherproduct = lstproduct
                .Where(p => p.ProductCategoryProducts.Any(pc => pc.CategoryProductId == category?.Id));

            ViewBag.otherproduct = otherproduct.Take(5).ToList();
            return View(product);
        }
        private List<CategoryProduct> GetCategories()
        {
            
            var categories = _context.CategoryProducts
                          .Include(c => c.ParentCategory)
                          .Include(c => c.CategoryChildren)
                          .AsEnumerable()
                          .Where(c => c.ParentCategory == null).ToList();
            return categories;
        }
        [HttpPost]
        [Route("/product/getphotos")]
        public IActionResult ListPhoto(int id)
        {
            var product = _context.Products.Include(p => p.Photos).FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return Json(
                    new
                    {
                        success = 0,
                        message = "Product not found"
                    }
                );
            }
            var listphoto = product.Photos.Select(p => new
            {
                id = p.Id,
                path = "/contents/Products/" + p.FileName
            });
            return Json(new
            {
                success = 1,
                photos = listphoto
            });
        }
        /// Thêm sản phẩm vào cart
        [Route("addcart/{productid:int}", Name = "addcart")]
        public IActionResult AddToCart([FromRoute] int productid)
        {

            var product = _context.Products
                .Where(p => p.ProductId == productid)
                .FirstOrDefault();
            if (product == null)
                return NotFound("Không có sản phẩm");

            // Xử lý đưa vào Cart ...
            var cart = _cartService.GetCartItems();
            var cartitem = cart.Find(p => p.product.ProductId == productid);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartitem.quantity++;
            }
            else
            {
                //  Thêm mới
                cart.Add(new CartItem() { quantity = 1, product = product });
            }

            // Lưu cart vào Session
            _cartService.SaveCartSession(cart);
            // Chuyển đến trang hiện thị Cart
            return RedirectToAction(nameof(Cart));
        }
        // Hiện thị giỏ hàng
        [Route("/cart", Name = "cart")]
        public IActionResult Cart()
        {
            return View(_cartService.GetCartItems());
        }
        /// Cập nhật
        [Route("/updatecart", Name = "updatecart")]
        [HttpPost]
        public IActionResult UpdateCart([FromForm] int productid, [FromForm] int quantity)
        {
            // Cập nhật Cart thay đổi số lượng quantity ...
            var cart = _cartService.GetCartItems();
            var cartitem = cart.Find(p => p.product.ProductId == productid);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                if (quantity < 0) quantity = 1;
                cartitem.quantity = quantity;
            }
            _cartService.SaveCartSession(cart);
            // Trả về mã thành công (không có nội dung gì - chỉ để Ajax gọi)
            return Ok();
        }

        /// xóa item trong cart
        [Route("/removecart/{productid:int}", Name = "removecart")]
        public IActionResult RemoveCart([FromRoute] int productid)
        {
            var cart = _cartService.GetCartItems();
            var cartitem = cart.Find(p => p.product.ProductId == productid);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cart.Remove(cartitem);
            }

            _cartService.SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }
    }
}
