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
using Bai1_ChinhThuc.Model.Product;

namespace Bai1_ChinhThuc.Areas.Product.Controllers
{
    [Area("Product")]
    [Route("/admin/categoryproduct/category/[action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class CategoryProductController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryProductController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Blog/Category
        public async Task<IActionResult> Index()
        {
            var qr = _context.CategoryProducts
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

            var category = await _context.CategoryProducts
                .Include(c => c.ParentCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
        void CreateSelectItem(List<CategoryProduct> source, List<CategoryProduct> des, int lever)
        {
            string prefix = string.Concat(Enumerable.Repeat("----", lever));
            foreach (var cate in source)
            {
                des.Add(new CategoryProduct()
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
            var qr = _context.CategoryProducts
                          .Include(c => c.ParentCategory)
                          .Include(c => c.CategoryChildren);
            List<CategoryProduct> ListCategory = new List<CategoryProduct>();
            ListCategory = qr.ToList().Where(c => c.ParentCategoryId == null).ToList();
            ListCategory.Insert(0, new CategoryProduct()
            {
                Id = -1,
                Title = "không có danh mục cha"
            });
            List<CategoryProduct> items = new List<CategoryProduct>();
            CreateSelectItem(ListCategory, items,  0);
            ViewData["ParentCategoryId"] = new SelectList(items, "Id", "Title", -1);
            return View();
        }

        // POST: Blog/Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ParentCategoryId,Title,Decreption,Slug")] CategoryProduct category)
        {
            if (ModelState.IsValid)
            {
                if (category.ParentCategoryId == -1)
                    category.ParentCategoryId = null;
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var qr = _context.CategoryProducts
                          .Include(c => c.ParentCategory)
                          .Include(c => c.CategoryChildren);
            List<CategoryProduct> ListCategory = new List<CategoryProduct>();
            ListCategory = qr.ToList().Where(c => c.ParentCategoryId == null).ToList();
            ListCategory.Insert(0, new CategoryProduct()
            {
                Id = -1,
                Title = "không có danh mục cha"
            });
            List<CategoryProduct> items = new List<CategoryProduct>();
            CreateSelectItem(ListCategory, items, 0);
            ViewData["ParentCategoryId"] = new SelectList(items, "Id", "Title", category.ParentCategoryId);
            return View(category);
        }
        public void SearchChild(List<CategoryProduct> CateChilds, List<CategoryProduct> des)
        {
            foreach(var cateChild in CateChilds)
            {
                des.Add(cateChild);
                List<CategoryProduct> lstChildOfCateChild = _context.CategoryProducts.Where(c => c.ParentCategoryId == cateChild.Id).ToList();
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

            var category = await _context.CategoryProducts.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            var qr = _context.CategoryProducts
                          .Include(c => c.ParentCategory)
                          .Include(c => c.CategoryChildren);
            List<CategoryProduct> ListCategory = new List<CategoryProduct>();
            ListCategory = qr.ToList().Where(c => c.ParentCategoryId == null).ToList();
            ListCategory.Insert(0, new CategoryProduct()
            {
                Id = -1,
                Title = "không có danh mục cha"
            });
            List<CategoryProduct> items = new List<CategoryProduct>();
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,ParentCategoryId,Title,Decreption,Slug")] CategoryProduct category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }


            
            if(category.ParentCategoryId == category.Id)
            {
                ModelState.AddModelError(string.Empty, "không thể chọn danh mục cha vừa rồi chọn");
            }
            
            List<CategoryProduct> lstChild_1 = _context.CategoryProducts.Where(c => c.ParentCategoryId == category.Id).ToList();
            List<CategoryProduct> lstChildAll = new List<CategoryProduct>();
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

            var qr = _context.CategoryProducts
                          .Include(c => c.ParentCategory)
                          .Include(c => c.CategoryChildren);
            List<CategoryProduct> ListCategory = new List<CategoryProduct>();
            ListCategory = qr.ToList().Where(c => c.ParentCategoryId == null).ToList();
            ListCategory.Insert(0, new CategoryProduct()
            {
                Id = -1,
                Title = "không có danh mục cha"
            });
            List<CategoryProduct> items = new List<CategoryProduct>();
            CreateSelectItem(ListCategory, items, 0);
            CategoryProduct cate = _context.CategoryProducts.FirstOrDefault(c => c.Id == id);
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

            var category = await _context.CategoryProducts
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

            var category = await _context.CategoryProducts
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
                _context.CategoryProducts.Remove(category);
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
            return _context.CategoryProducts.Any(e => e.Id == id);
        }
    }
}
