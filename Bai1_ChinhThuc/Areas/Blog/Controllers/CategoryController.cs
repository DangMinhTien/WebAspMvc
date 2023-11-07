using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bai1_ChinhThuc.Model;
using Microsoft.AspNetCore.Authorization;
using Bai1_ChinhThuc.Model.Blog;

namespace Bai1_ChinhThuc.Areas.Blog.Controllers
{
    [Area("Blog")]
    [Route("/admin/blog/category/[action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Blog/Category
        public async Task<IActionResult> Index()
        {
            var qr = _context.Categories
                          .Include(c => c.ParentCategory)
                          .Include(c => c.CategoryChildren);
            var ListCategory = qr.ToList().Where(c => c.ParentCategoryId == null);
            return View(ListCategory);
        }

        // GET: Blog/Category/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .Include(c => c.ParentCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
        void CreateSelectItem(List<Category> source, List<Category> des, int lever)
        {
            string prefix = string.Concat(Enumerable.Repeat("----", lever));
            foreach (var cate in source)
            {
                des.Add(new Category()
                {
                    Id = cate.Id,
                    Title = prefix + cate.Title,
                });
                if(cate.CategoryChildren?.Count > 0)
                {
                    CreateSelectItem(cate.CategoryChildren.ToList(), des, lever + 1);
                }
            }
        }
        // GET: Blog/Category/Create
        public async Task<IActionResult> Create()
        {
            var qr = _context.Categories
                          .Include(c => c.ParentCategory)
                          .Include(c => c.CategoryChildren);
            List<Category> ListCategory = new List<Category>();
            ListCategory = qr.ToList().Where(c => c.ParentCategoryId == null).ToList();
            ListCategory.Insert(0, new Category()
            {
                Id = -1,
                Title = "không có danh mục cha"
            });
            List<Category> items = new List<Category>();
            CreateSelectItem(ListCategory, items,  0);
            ViewData["ParentCategoryId"] = new SelectList(items, "Id", "Title", -1);
            return View();
        }

        // POST: Blog/Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ParentCategoryId,Title,Decreption,Slug")] Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.ParentCategoryId == -1)
                    category.ParentCategoryId = null;
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ParentCategoryId"] = new SelectList(_context.Categories, "Id", "Slug", category.ParentCategoryId);
            return View(category);
        }
        public void SearchChild(List<Category> CateChilds, List<Category> des)
        {
            foreach(var cateChild in CateChilds)
            {
                des.Add(cateChild);
                List<Category> lstChildOfCateChild = _context.Categories.Where(c => c.ParentCategoryId == cateChild.Id).ToList();
                if(lstChildOfCateChild?.Count > 0)
                {
                    SearchChild(cateChild.CategoryChildren.ToList(), des);
                }
            }
        }

        // GET: Blog/Category/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            var qr = _context.Categories
                          .Include(c => c.ParentCategory)
                          .Include(c => c.CategoryChildren);
            List<Category> ListCategory = new List<Category>();
            ListCategory = qr.ToList().Where(c => c.ParentCategoryId == null).ToList();
            ListCategory.Insert(0, new Category()
            {
                Id = -1,
                Title = "không có danh mục cha"
            });
            List<Category> items = new List<Category>();
            CreateSelectItem(ListCategory, items, 0);
            var selected = category.ParentCategoryId;
            if (selected == null)
                selected = -1;
            ViewData["ParentCategoryId"] = new SelectList(items, "Id", "Title", selected);
            return View(category);
        }

        // POST: Blog/Category/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ParentCategoryId,Title,Decreption,Slug")] Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }


            
            if(category.ParentCategoryId == category.Id)
            {
                ModelState.AddModelError(string.Empty, "không thể chọn danh mục cha vừa rồi chọn");
            }
            
            List<Category> lstChild_1 = _context.Categories.Where(c => c.ParentCategoryId == category.Id).ToList();
            List<Category> lstChildAll = new List<Category>();
            SearchChild(lstChild_1, lstChildAll);
            foreach(var item in lstChildAll)
            {
                if(item.Id == category.ParentCategoryId)
                {
                    ModelState.AddModelError(string.Empty, "không thể chọn danh mục cha vừa rồi chọn");
                }
            }
                                                    
            if (ModelState.IsValid)
            {
                if (category.ParentCategoryId == -1)
                    category.ParentCategoryId = null;
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            };

            var qr = _context.Categories
                          .Include(c => c.ParentCategory)
                          .Include(c => c.CategoryChildren);
            List<Category> ListCategory = new List<Category>();
            ListCategory = qr.ToList().Where(c => c.ParentCategoryId == null).ToList();
            ListCategory.Insert(0, new Category()
            {
                Id = -1,
                Title = "không có danh mục cha"
            });
            List<Category> items = new List<Category>();
            CreateSelectItem(ListCategory, items, 0);
            Category cate = _context.Categories.FirstOrDefault(c => c.Id == id);
            var selected = cate.ParentCategoryId;
            if (selected == null)
                selected = -1;
            ViewData["ParentCategoryId"] = new SelectList(items, "Id", "Title", selected);
            return View(category);
        }

        // GET: Blog/Category/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .Include(c => c.ParentCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Blog/Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .Include(c => c.CategoryChildren)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            foreach(var childCate in category.CategoryChildren)
            {
                childCate.ParentCategoryId = category.ParentCategoryId;
            }
            try
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                return NotFound("Có lỗi Khi xóa" + ex.Message);
            }
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
