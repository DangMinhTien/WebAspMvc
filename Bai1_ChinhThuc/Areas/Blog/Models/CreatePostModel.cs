using Bai1_ChinhThuc.Model.Blog;
using System.ComponentModel.DataAnnotations;

namespace Bai1_ChinhThuc.Areas.Blog.Models
{
    public class CreatePostModel : Post
    {
        [Display(Name = "Chuyên mục")]
        public int[] CategoryIds { get; set; }
    }
}
