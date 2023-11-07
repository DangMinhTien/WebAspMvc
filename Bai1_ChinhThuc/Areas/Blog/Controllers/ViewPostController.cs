using Bai1_ChinhThuc.Helper;
using Bai1_ChinhThuc.Model;
using Bai1_ChinhThuc.Model.Blog;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;

namespace Bai1_ChinhThuc.Areas.Blog.Controllers
{
    [Area("Blog")]
    public class ViewPostController : Controller
    {
        private readonly ILogger<ViewPostController> _logger;
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public ViewPostController(
            ILogger<ViewPostController> logger, 
            AppDbContext context,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public int pagesize { get; set; } = 10;
        [Route("/post/{categoriesSlug?}")]
        public IActionResult Index(string categoriesSlug,[FromQuery(Name = "p")] int? currentpage)
        {
            var categories = GetCategories();
            ViewBag.categories = categories;
            ViewBag.categoriesSlug = categoriesSlug;
            Category Category = null;
            if(!string.IsNullOrEmpty(categoriesSlug)) 
            {
                Category = _context.Categories.Include(c => c.CategoryChildren)
                                              .FirstOrDefault(c => c.Slug == categoriesSlug);
                if(Category == null)
                {
                    return NotFound("không thấy category");
                }
            }
            ViewBag.category = Category;
            var posts = _context.Posts
                                .Include(p => p.Author)
                                .Include(p => p.PostCategories)
                                .ThenInclude(pc => pc.Category)
                                .ToList();
            posts.OrderByDescending(p => p.DateUpdated);
            if(Category != null)
            {
                List<int> IdCate = new List<int>();
                Category.GetChildCategies(null,IdCate);
                IdCate.Add(Category.Id);
                posts = posts.Where(p => p.PostCategories.Where(pc => IdCate.Contains(pc.CategoryId)).Any()).ToList();

            }
            // bắt đầu phân trang
            int total = posts.Count();
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
                generateUrl = (p) => Url.Action("Index", "ViewPost", new { area = "Blog", p = p })
            };
            ViewBag.pagingmodel = pagingmodel;
            ViewBag.totalPost = total;
            ViewBag.PageIndex = ((currentpage - 1) * pagesize) + 1;
            var postsInpage = posts.Skip((int)(currentpage - 1) * pagesize)
                        .Take(pagesize)
                        .ToList();
            //kết thúc phân trang

            return View(postsInpage);
        }
        [Route("/post/{postSlug}.html")]
        public IActionResult Details(string postSlug)
        {
            var categories = GetCategories();
            ViewBag.categories = categories;

            var post = _context.Posts
                                .Include(p => p.Author)
                                .Include(p => p.PostCategories)
                                .ThenInclude(pc => pc.Category)
                                .FirstOrDefault(p => p.Slug == postSlug);
            if(post == null)
            {
                return NotFound();
            }
            Category category = post.PostCategories.FirstOrDefault()?.Category;
            ViewBag.category = category;
            var lstpost = _context.Posts.Include(p => p.PostCategories).ToList();
            var otherpost = lstpost
                .Where(p => p.PostCategories.Any(pc => pc.CategoryId == category?.Id));

            ViewBag.otherpost = otherpost.Take(5).ToList();
            return View(post);
        }
        private List<Category> GetCategories()
        {
            
            var categories = _context.Categories
                          .Include(c => c.ParentCategory)
                          .Include(c => c.CategoryChildren)
                          .AsEnumerable()
                          .Where(c => c.ParentCategory == null).ToList();
            return categories;
        }
    }
}
