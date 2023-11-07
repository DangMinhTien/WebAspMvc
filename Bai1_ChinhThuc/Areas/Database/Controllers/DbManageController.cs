using Bai1_ChinhThuc.Model;
using Bai1_ChinhThuc.Model.Blog;
using Bai1_ChinhThuc.Model.Product;
using Bogus;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Bai1_ChinhThuc.Areas.Database.Controllers
{
    [Area("Database")]
    [Route("database-manage/[action]")]
    [Authorize(Roles = "Admin,Editor")]
    public class DbManageController : Controller
    {
        private readonly AppDbContext _dbcontext;
        private readonly UserManager<AppUser> _userManager;
        public DbManageController(AppDbContext dbContext, UserManager<AppUser> userManager)
        {
            _dbcontext = dbContext;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SeedData()
        {
            //await SeedCategoryPost();
            await SeedCategoryProduct();
            return RedirectToAction("Index");
            //End POST
        }

        public async Task SeedCategoryPost()
        {
            _dbcontext.Categories.RemoveRange(_dbcontext.Categories.Where(c => c.Decreption.Contains("[fakedata]")));
            _dbcontext.Posts.RemoveRange(_dbcontext.Posts.Where(c => c.Content.Contains("[fakedata]")));

            var fakeCategory = new Faker<Category>();
            int cm = 1;
            fakeCategory.RuleFor(c => c.Title, fk => $"CM{cm++}" + fk.Lorem.Sentence(1, 2).Trim('.'));
            fakeCategory.RuleFor(c => c.Decreption, fk => fk.Lorem.Sentence(5) + "[fakedata]");
            fakeCategory.RuleFor(c => c.Slug, fk => fk.Lorem.Slug());

            var cate1 = fakeCategory.Generate();
            var cate11 = fakeCategory.Generate();
            var cate12 = fakeCategory.Generate();
            var cate2 = fakeCategory.Generate();
            var cate21 = fakeCategory.Generate();
            var cate211 = fakeCategory.Generate();
            cate11.ParentCategory = cate1;
            cate12.ParentCategory = cate1;
            cate21.ParentCategory = cate2;
            cate211.ParentCategory = cate21;
            var categories = new Category[] { cate1, cate11, cate12, cate2, cate21, cate211 };
            _dbcontext.Categories.AddRange(categories);


            //Start POST
            var rCateIndex = new Random();
            int bv = 1;
            var user = _userManager.GetUserAsync(this.User).Result;

            var fakePost = new Faker<Post>();
            fakePost.RuleFor(p => p.AuthorId, f => user.Id);
            fakePost.RuleFor(p => p.Content, f => f.Lorem.Paragraph(7) + "[fakedata]");
            fakePost.RuleFor(p => p.DateCreated, f => f.Date.Between(new DateTime(2021, 1, 1), new DateTime(2021, 7, 1)));
            fakePost.RuleFor(p => p.Decerption, f => f.Lorem.Sentence(3));
            fakePost.RuleFor(p => p.Published, f => true);
            fakePost.RuleFor(p => p.Slug, f => f.Lorem.Slug());
            fakePost.RuleFor(p => p.Title, fk => $"Bài {bv++}" + fk.Lorem.Sentence(3, 4).Trim('.'));

            List<Post> posts = new List<Post>();
            List<PostCategory> post_categories = new List<PostCategory>();
            for (int i = 1; i <= 40; i++)
            {
                var post = fakePost.Generate();
                post.DateUpdated = post.DateCreated;
                posts.Add(post);
                post_categories.Add(new PostCategory()
                {
                    Post = post,
                    Category = categories[rCateIndex.Next(5)]
                });
            }
            _dbcontext.AddRange(posts);
            _dbcontext.AddRange(post_categories);

            await _dbcontext.SaveChangesAsync();
        }

        public async Task SeedCategoryProduct()
        {
            _dbcontext.CategoryProducts.RemoveRange(_dbcontext.CategoryProducts.Where(c => c.Decreption.Contains("[fakedata]")));
            _dbcontext.Products.RemoveRange(_dbcontext.Products.Where(c => c.Content.Contains("[fakedata]")));

            var fakeCategory = new Faker<CategoryProduct>();
            int cm = 1;
            fakeCategory.RuleFor(c => c.Title, fk => $"Nhóm sp{cm++}" + fk.Lorem.Sentence(1, 2).Trim('.'));
            fakeCategory.RuleFor(c => c.Decreption, fk => fk.Lorem.Sentence(5) + "[fakedata]");
            fakeCategory.RuleFor(c => c.Slug, fk => fk.Lorem.Slug());

            var cate1 = fakeCategory.Generate();
            var cate11 = fakeCategory.Generate();
            var cate12 = fakeCategory.Generate();
            var cate2 = fakeCategory.Generate();
            var cate21 = fakeCategory.Generate();
            var cate211 = fakeCategory.Generate();
            cate11.ParentCategory = cate1;
            cate12.ParentCategory = cate1;
            cate21.ParentCategory = cate2;
            cate211.ParentCategory = cate21;
            var categories = new CategoryProduct[] { cate1, cate11, cate12, cate2, cate21, cate211 };
            _dbcontext.CategoryProducts.AddRange(categories);


            //Start POST
            var rCateIndex = new Random();
            int sp = 1;
            var user = _userManager.GetUserAsync(this.User).Result;

            var fakeProduct = new Faker<ProductModel>();
            fakeProduct.RuleFor(p => p.Content, f => f.Commerce.ProductDescription() + "[fakedata]");
            fakeProduct.RuleFor(p => p.DateCreated, f => f.Date.Between(new DateTime(2021, 1, 1), new DateTime(2021, 7, 1)));
            fakeProduct.RuleFor(p => p.Decerption, f => f.Lorem.Sentence(3));
            fakeProduct.RuleFor(p => p.Published, f => true);
            fakeProduct.RuleFor(p => p.Slug, f => f.Lorem.Slug());
            fakeProduct.RuleFor(p => p.Title, fk => $"SP {sp++}" + fk.Commerce.ProductName());
            fakeProduct.RuleFor(p => p.Price, fk => int.Parse(fk.Commerce.Price(500, 1000, 0)));

            List<ProductModel> products = new List<ProductModel>();
            List<ProductCategoryProduct> product_categoryproducts = new List<ProductCategoryProduct>();
            for (int i = 1; i <= 40; i++)
            {
                var product = fakeProduct.Generate();
                product.DateUpdated = product.DateCreated;
                products.Add(product);
                product_categoryproducts.Add(new ProductCategoryProduct()
                {
                    Product = product,
                    CategoryProduct = categories[rCateIndex.Next(5)]
                });
            }
            _dbcontext.AddRange(products);
            _dbcontext.AddRange(product_categoryproducts);

            await _dbcontext.SaveChangesAsync();
        }
    }
}
