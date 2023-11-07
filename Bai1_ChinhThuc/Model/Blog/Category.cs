using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Linq;

namespace Bai1_ChinhThuc.Model.Blog
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        // Category cha (FKey)
        [Display(Name = "Danh mục cha")]
        public int? ParentCategoryId { get; set; }

        // Tiều đề Category
        [Required(ErrorMessage = "Phải có tên danh mục")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} dài {1} đến {2}")]
        [Display(Name = "Tên danh mục")]
        public string Title { get; set; }

        // Nội dung, thông tin chi tiết về Category
        [Required(ErrorMessage = "Phải có {0}")]
        [DataType(DataType.Text)]
        [Display(Name = "Nội dung danh mục")]
        public string Decreption { set; get; }

        //chuỗi Url
        [Required(ErrorMessage = "Phải tạo url")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} dài {1} đến {2}")]
        [RegularExpression(@"^[a-z0-9-]*$", ErrorMessage = "Chỉ dùng các ký tự [a-z0-9-]")]
        [Display(Name = "Url hiện thị")]
        public string Slug { set; get; }

        // Các Category con
        public ICollection<Category> CategoryChildren { get; set; }

        [ForeignKey("ParentCategoryId")]
        [Display(Name = "Danh mục cha")]


        public Category ParentCategory { set; get; }

        public void GetChildCategies(List<Category> childCategories = null, List<int> IdChildCate = null)
        {
            if (childCategories == null)
                childCategories = this.CategoryChildren.ToList();
            foreach (Category childCategory in childCategories)
            {
                IdChildCate.Add(childCategory.Id);
                if(childCategory.CategoryChildren?.Count > 0)
                {
                    GetChildCategies(childCategory.CategoryChildren.ToList(), IdChildCate);
                }
            }
        }
        public List<Category> GetParents()
        {
            List<Category> li = new List<Category>();
            var parent = this.ParentCategory;
            while(parent != null)
            {
                li.Add(parent);
                parent = parent.ParentCategory;
            }
            li.Reverse();
            return li;
        }
    }
}
