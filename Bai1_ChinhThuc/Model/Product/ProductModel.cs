using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai1_ChinhThuc.Model.Product
{
    [Table("Product")]
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Phải có tiêu đề bài viết")]
        [DisplayName("Tiêu đề")]
        [StringLength(160, MinimumLength = 5, ErrorMessage = "{0} phải có độ dài từ {1} đến {2}")]
        public string Title { get; set; }
        [DisplayName("Mô tả ngắn")]
        public string Decerption { get; set; }
        [Display(Name = "Chuỗi định danh (url)", Prompt = "Nhập hoặc để trống tự phát sinh theo Title")]
        [StringLength(160, MinimumLength = 5, ErrorMessage = "{0} phải có độ dài từ {1} đến {2}")]
        [RegularExpression(@"^[a-z0-9-]*$", ErrorMessage = "Chỉ dùng các ký tự [a-z0-9-]")]
        public string Slug { get; set; }
        [Display(Name = "Nội dung")]
        [Required(ErrorMessage = "Phải có {0} bài viết")]
        public string Content { get; set; }
        [Display(Name = "Xuất bản")]
        public bool Published { get; set; }

        
        
        [Display(Name = "Ngày tạo")]
        public DateTime DateCreated { get; set; }
        [Display(Name = "Ngày cập nhật")]
        public DateTime DateUpdated { get; set; }
        [Display(Name = "Giá bán")]
        [Range(0, int.MaxValue, ErrorMessage = "{0} giá bán phải lớn hơn {1}")]
        
        public decimal Price { get; set; }
        public List<ProductCategoryProduct> ProductCategoryProducts { get; set; }
        public List<ProductPhoto> Photos { get; set; }
    }
}
