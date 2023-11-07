using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bai1_ChinhThuc.Model;
using Bai1_ChinhThuc.Model.Blog;
using Microsoft.AspNetCore.Authorization;
using Bai1_ChinhThuc.Helper;
using Bai1_ChinhThuc.Areas.Blog.Models;
using Microsoft.AspNetCore.Identity;
using Bai1_ChinhThuc.Ultilities;
using Bai1_ChinhThuc.Areas.Product.Models;
using Bai1_ChinhThuc.Model.Product;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.IO;
using QLKHO.Validation;

namespace Bai1_ChinhThuc.Areas.Product.Controllers
{
    [Area("Product")]
    [Route("/admin/product/product/[action]/{id?}")]
    [Authorize(Roles = "Admin,Editor")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ProductController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [TempData]
        public string StatusMessage { get; set; }
        public int pagesize = 10;

        // GET: Blog/Post
        public async Task<IActionResult> Index([FromQuery(Name = "p")]int? currentpage)
        {
            var products = await _context.Products
                        .Include(p => p.ProductCategoryProducts)
                        .ThenInclude(pc => pc.CategoryProduct)
                        .OrderByDescending(p => p.DateUpdated)
                        .ToListAsync();
            int total = products.Count;
            int totalPages = (int)Math.Ceiling((double)total/pagesize);
            if (currentpage == null) currentpage = 1;
            if (currentpage < 1)
                currentpage = 1;
            if(currentpage > totalPages)
                currentpage = totalPages;
            var pagingmodel = new PagingModel()
            {
                countPage = totalPages,
                currentPage = (int)currentpage,
                generateUrl = (p) => Url.Action("Index","Product",new {area = "Product", p = p})
            };
            ViewBag.pagingmodel = pagingmodel;
            ViewBag.totalPost = total;
            ViewBag.PageIndex = ((currentpage - 1) * pagesize) + 1;
            var productInpage = products.Skip((int)(currentpage - 1) * pagesize)
                        .Take(pagesize)
                        .ToList();
            return View(productInpage);
        }

        // GET: Blog/Post/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductCategoryProducts)
                .ThenInclude(pc => pc.CategoryProduct)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Blog/Post/Create
        public async Task<IActionResult> Create()
        {
            var categories = await _context.CategoryProducts.ToListAsync();
            ViewBag.categories = new MultiSelectList(categories, "Id", "Title");
            return View();
        }

        // POST: Blog/Post/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Decerption,Slug,Content,Published,CategoryProductIds,Price")] CreateProductModel product)
        {
            if (product.Slug == null)
                product.Slug = Ultilities.AppUltiliti.GenerateSlug(product.Title);
            if(await _context.Products.AnyAsync(p => p.Slug == product.Slug))
            {
                ModelState.AddModelError(string.Empty, "Slug bị trùng với các bài viết khác");
            }
            if (ModelState.IsValid)
            {
                product.DateCreated = DateTime.Now;
                product.DateUpdated = DateTime.Now;
                _context.Add(product);
                if(product.CategoryProductIds != null)
                {
                    foreach(var cateId in product.CategoryProductIds)
                    {
                        _context.ProductCategoryProducts.Add(new Model.Product.ProductCategoryProduct()
                        {
                            CategoryProductId = cateId,
                            Product = product
                        });
                    }
                }
                await _context.SaveChangesAsync();
                StatusMessage = "Bạn vừa thêm bài viết thành công";
                return RedirectToAction(nameof(Index));
            }
            var categories = await _context.CategoryProducts.ToListAsync();
            ViewBag.categories = new MultiSelectList(categories, "Id", "Title");
            return View(product);
        }

        // GET: Blog/Post/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = (await _context.Products
                .Include(p => p.ProductCategoryProducts)
                .ThenInclude(pc => pc.CategoryProduct).ToListAsync()).FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            var productEdit = new CreateProductModel()
            {
                ProductId = product.ProductId,
                Title = product.Title,
                Decerption = product.Decerption,
                Content = product.Content,
                Slug= product.Slug,
                Published = product.Published,
                Price = product.Price,
                CategoryProductIds = product.ProductCategoryProducts.Select(pc => pc.CategoryProductId).ToArray(),
            };
            var categories = await _context.CategoryProducts.ToListAsync();
            ViewBag.categories = new MultiSelectList(categories, "Id", "Title", productEdit.CategoryProductIds);
            return View(productEdit);
        }

        // POST: Blog/Post/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,Title,Decerption,Slug,Content,Published,CategoryProductIds,Price")] CreateProductModel product)
        {
            if (id != product.ProductId)
            {
                return NotFound("Không thấy gì...");
            }
            if (product.Slug == null)
                product.Slug = Ultilities.AppUltiliti.GenerateSlug(product.Title);
            if (await _context.Products.AnyAsync(p => p.Slug == product.Slug && p.ProductId != product.ProductId))
            {
                ModelState.AddModelError(string.Empty, "Slug bị trùng với các bài viết khác");
            }
            if (ModelState.IsValid)
            {
                try
                {
                    ProductModel productUpdate = _context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
                    if(productUpdate == null)
                    {
                        return NotFound("Oke");
                    }
                    productUpdate.Title = product.Title;
                    productUpdate.Decerption = product.Decerption;
                    productUpdate.Slug = product.Slug;
                    productUpdate.Content = product.Content;
                    productUpdate.Published = product.Published;
                    productUpdate.DateUpdated = DateTime.UtcNow;
                    productUpdate.Price = product.Price;
                    _context.Update(productUpdate);
                    var p = (await _context.Products
                                       .Include(p => p.ProductCategoryProducts)
                                       .ThenInclude(pc => pc.CategoryProduct).ToListAsync()).FirstOrDefault(p => p.ProductId == id);
                    var cateIdOld = p.ProductCategoryProducts.Select(pc => pc.CategoryProductId).ToArray();
                    foreach(var cateId in cateIdOld)
                    {
                        _context.Remove(_context.ProductCategoryProducts.FirstOrDefault(pc => pc.CategoryProductId == cateId && pc.ProductId == product.ProductId));
                    }
                    if(product.CategoryProductIds?.Count() > 0)
                    {
                        foreach (var cateId in product.CategoryProductIds)
                        {
                            _context.Add(new ProductCategoryProduct()
                            {
                                CategoryProductId = cateId,
                                ProductId = product.ProductId,
                            });
                        }
                    }
                    StatusMessage = "Bạn vừa sửa thành công bài viết";
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            var categories = await _context.CategoryProducts.ToListAsync();
            ViewBag.categories = new MultiSelectList(categories, "Id", "Title", product.CategoryProductIds);
            return View(product);
        }

        // GET: Blog/Post/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Blog/Post/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if(product == null)
            {
                return NotFound();
            }
            try
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
            catch
            {
                return NotFound("không xóa được");
            }
            StatusMessage = "Xóa thành công";
            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
        public class UploadOneFile
        {
            [Required(ErrorMessage = "Phải chọn 1 file")]
            [DataType(DataType.Upload)]
            [ChkFileExtension(Extensions = "png,jpg,jpeg,gif", ErrorMessage = "Phải chọn các file có đuôi .png, .jpg, .jpeg, .gif")]
            [Display(Name = "Chọn file Upload")]
            public IFormFile FileUpload { get; set; }
        }
        [HttpGet]
        public IActionResult UploadPhoto(int id)
        {
            var product = _context.Products.Include(p => p.Photos).FirstOrDefault(p => p.ProductId == id);
            if (product == null)
                return NotFound("không tìm thấy sản phẩm");
            ViewData["product"] = product;
            return View();
        }
        [HttpPost]
        [ActionName("UploadPhoto")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UploadPhotoAsync(int id, [Bind("FileUpload")]UploadOneFile f)
        {
            var product = _context.Products.Include(p => p.Photos).FirstOrDefault(p => p.ProductId == id);
            if (product == null)
                return NotFound("không tìm thấy sản phẩm");
            ViewData["product"] = product;
            if(ModelState.IsValid)
            {
                if(f != null)
                {
                    var file1 = Path.GetFileNameWithoutExtension(Path.GetRandomFileName())
                                                + Path.GetExtension(f.FileUpload.FileName);
                    var file = Path.Combine("Uploads", "Products", file1);
                    using(var filestream = new FileStream(file, FileMode.Create))
                    {
                        await f.FileUpload.CopyToAsync(filestream);
                    }
                    _context.ProductPhotos.Add(new ProductPhoto()
                    {
                        FileName = file1,
                        ProductId = id,
                    });
                    _context.SaveChanges();
                }
            }
            return View();
        }
        [HttpPost]
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
        [HttpPost]
        public async Task<IActionResult> DeletePhoto(int id)
        {
            var photo = await _context.ProductPhotos.FirstOrDefaultAsync(p => p.Id == id);
            if (photo != null)
            {
                _context.ProductPhotos.Remove(photo);
                _context.SaveChanges();

                var fileName = "Uploads/Products/" + photo.FileName;
                System.IO.File.Delete(fileName);
            }
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> UploadPhotoAPI(int id, [Bind("FileUpload")] UploadOneFile f)
        {
            var product = _context.Products.Include(p => p.Photos).FirstOrDefault(p => p.ProductId == id);
            if (product == null)
                return NotFound("không tìm thấy sản phẩm");
            if (ModelState.IsValid)
            {
                if (f != null)
                {
                    var file1 = Path.GetFileNameWithoutExtension(Path.GetRandomFileName())
                                                + Path.GetExtension(f.FileUpload.FileName);
                    var file = Path.Combine("Uploads", "Products", file1);
                    using (var filestream = new FileStream(file, FileMode.Create))
                    {
                        await f.FileUpload.CopyToAsync(filestream);
                    }
                    _context.ProductPhotos.Add(new ProductPhoto()
                    {
                        FileName = file1,
                        ProductId = id,
                    });
                    _context.SaveChanges();
                }
            }
            return Ok();
        }
    }
}
