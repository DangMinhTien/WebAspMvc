using Bai1_ChinhThuc.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Bai1_ChinhThuc.Areas.Admin.Pages.Roles
{
    public class AddRoleClaimModel : RolePageModel
    {
        public AddRoleClaimModel(RoleManager<IdentityRole> _rolemanage, AppDbContext _dbcontext) : base(_rolemanage, _dbcontext)
        {
        }
        public class InputModel
        {
            [Required(ErrorMessage = "{0} không được để trống")]
            [StringLength(256, MinimumLength = 3, ErrorMessage = "{0} phải có độ dài từ {2} đến {1}")]
            [DisplayName("Kiểu Claim")]
            public string ClaimType { get; set; }

            [Required(ErrorMessage = "{0} không được để trống")]
            [StringLength(256, MinimumLength = 3, ErrorMessage = "{0} phải có độ dài từ {2} đến {1}")]
            [DisplayName("Giá trị Claim")]
            public string ClaimValue { get; set; }
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public IdentityRole role { get; set; }
        public async Task<IActionResult> OnGet(string roleid)
        {
            role = await rolemanage.FindByIdAsync(roleid);
            if(role == null)
            {
                return NotFound("Không tìm thấy role");
            }
            Input = new InputModel();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string roleid)
        {
            role = await rolemanage.FindByIdAsync(roleid);
            if(role == null)
            {
                return NotFound("Không tìm thấy role");
            }
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if((await rolemanage.GetClaimsAsync(role)).Any(c => c.Type == Input.ClaimType && c.Value == Input.ClaimValue))
            {
                ModelState.AddModelError(string.Empty, "Claim này đã có trong role");
                return Page();
            }
            var newClaim = new Claim(Input.ClaimType, Input.ClaimValue);
            var result = await rolemanage.AddClaimAsync(role, newClaim);
            if (!result.Succeeded)
            {
                foreach(var error in result.Errors.ToList()) 
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return Page();
            }
            StatusMessage = "Bạn vưa thêm đặc tính mới cho role";
            return RedirectToPage("./Edit",new {roleid = role.Id});
        }
    }
}
