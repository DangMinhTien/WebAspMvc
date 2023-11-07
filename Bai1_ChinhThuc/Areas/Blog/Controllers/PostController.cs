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

namespace Bai1_ChinhThuc.Areas.Blog.Controllers
{
    [Area("Blog")]
    [Route("/admin/blog/post/[action]/{id?}")]
    [Authorize(Roles = "Admin,Editor")]
    public class PostController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public PostController(AppDbContext context, UserManager<AppUser> userManager)
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
            var posts = await _context.Posts
                        .Include(p => p.Author)
                        .Include(p => p.PostCategories)
                        .ThenInclude(pc => pc.Category)
                        .OrderByDescending(p => p.DateUpdated)
                        .ToListAsync();
            int total = posts.Count;
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
                generateUrl = (p) => Url.Action("Index","Post",new {area = "Blog", p = p})
            };
            ViewBag.pagingmodel = pagingmodel;
            ViewBag.totalPost = total;
            ViewBag.PageIndex = ((currentpage - 1) * pagesize) + 1;
            var postsInpage = posts.Skip((int)(currentpage - 1) * pagesize)
                        .Take(pagesize)
                        .ToList();
            return View(postsInpage);
        }

        // GET: Blog/Post/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.Author)
                .Include(p => p.PostCategories)
                .ThenInclude(pc => pc.Category)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Blog/Post/Create
        public async Task<IActionResult> Create()
        {
            var categories = await _context.Categories.ToListAsync();
            ViewBag.categories = new MultiSelectList(categories, "Id", "Title");
            return View();
        }

        // POST: Blog/Post/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Decerption,Slug,Content,Published,CategoryIds")] CreatePostModel post)
        {
            if (post.Slug == null)
                post.Slug = Ultilities.AppUltiliti.GenerateSlug(post.Title);
            if(await _context.Posts.AnyAsync(p => p.Slug == post.Slug))
            {
                ModelState.AddModelError(string.Empty, "Slug bị trùng với các bài viết khác");
            }
            if (ModelState.IsValid)
            {
                post.DateCreated = DateTime.Now;
                post.DateUpdated = DateTime.Now;
                post.AuthorId = (await _userManager.GetUserAsync(User)).Id;
                _context.Add(post);
                if(post.CategoryIds != null)
                {
                    foreach(var cateId in post.CategoryIds)
                    {
                        _context.PostCategories.Add(new PostCategory()
                        {
                            CategoryId = cateId,
                            Post = post
                        });
                    }
                }
                await _context.SaveChangesAsync();
                StatusMessage = "Bạn vừa thêm bài viết thành công";
                return RedirectToAction(nameof(Index));
            }
            var categories = await _context.Categories.ToListAsync();
            ViewBag.categories = new MultiSelectList(categories, "Id", "Title");
            return View(post);
        }

        // GET: Blog/Post/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = (await _context.Posts
                .Include(p => p.PostCategories)
                .ThenInclude(pc => pc.Category).ToListAsync()).FirstOrDefault(p => p.PostId == id);
            if (post == null)
            {
                return NotFound();
            }
            var postEdit = new CreatePostModel()
            {
                PostId = post.PostId,
                Title = post.Title,
                Decerption = post.Decerption,
                Content = post.Content,
                Slug= post.Slug,
                Published = post.Published,
                CategoryIds = post.PostCategories.Select(pc => pc.CategoryId).ToArray(),
            };
            var categories = await _context.Categories.ToListAsync();
            ViewBag.categories = new MultiSelectList(categories, "Id", "Title", postEdit.CategoryIds);
            return View(postEdit);
        }

        // POST: Blog/Post/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostId,Title,Decerption,Slug,Content,Published,CategoryIds")] CreatePostModel post)
        {
            if (id != post.PostId)
            {
                return NotFound();
            }
            if (post.Slug == null)
                post.Slug = Ultilities.AppUltiliti.GenerateSlug(post.Title);
            if (await _context.Posts.AnyAsync(p => p.Slug == post.Slug && p.PostId != post.PostId))
            {
                ModelState.AddModelError(string.Empty, "Slug bị trùng với các bài viết khác");
            }
            if (ModelState.IsValid)
            {
                try
                {
                    Post postUpdate = _context.Posts.FirstOrDefault(p => p.PostId == post.PostId);
                    if(postUpdate == null)
                    {
                        return NotFound();
                    }
                    postUpdate.Title = post.Title;
                    postUpdate.Decerption = post.Decerption;
                    postUpdate.Slug = post.Slug;
                    postUpdate.Content = post.Content;
                    postUpdate.Published = post.Published;
                    postUpdate.DateUpdated = DateTime.UtcNow;
                    _context.Update(postUpdate);
                    var p = (await _context.Posts
                                       .Include(p => p.PostCategories)
                                       .ThenInclude(pc => pc.Category).ToListAsync()).FirstOrDefault(p => p.PostId == id);
                    var cateIdOld = p.PostCategories.Select(pc => pc.CategoryId).ToArray();
                    foreach(var cateId in cateIdOld)
                    {
                        _context.Remove(_context.PostCategories.FirstOrDefault(pc => pc.CategoryId == cateId && pc.PostId == post.PostId));
                    }
                    if(post.CategoryIds?.Count() > 0)
                    {
                        foreach (var cateId in post.CategoryIds)
                        {
                            _context.Add(new PostCategory()
                            {
                                CategoryId = cateId,
                                PostId = post.PostId,
                            });
                        }
                    }
                    StatusMessage = "Bạn vừa sửa thành công bài viết";
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.PostId))
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
            var categories = await _context.Categories.ToListAsync();
            ViewBag.categories = new MultiSelectList(categories, "Id", "Title", post.CategoryIds);
            return View(post);
        }

        // GET: Blog/Post/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.Author)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Blog/Post/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if(post == null)
            {
                return NotFound();
            }
            try
            {
                _context.Posts.Remove(post);
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
            return _context.Posts.Any(e => e.PostId == id);
        }
    }
}
