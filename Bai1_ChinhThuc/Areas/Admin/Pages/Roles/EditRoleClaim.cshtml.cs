using Bai1_ChinhThuc.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Linq;

namespace Bai1_ChinhThuc.Areas.Admin.Pages.Roles
{
    public class EditRoleClaimModel : RolePageModel
    {
        public EditRoleClaimModel(RoleManager<IdentityRole> _rolemanage, AppDbContext _dbcontext) : base(_rolemanage, _dbcontext)
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
        public IdentityRoleClaim<string> claim { get; set; }
        public async Task<IActionResult> OnGet(int? claimid)
        {
            if(claimid == null)
                return NotFound("Không tìm thấy claim");
            claim = dbcontext.RoleClaims.FirstOrDefault(c => c.Id == claimid);
            if (claim == null)
                return NotFound("Không tìm thấy claim");
            role = await rolemanage.FindByIdAsync(claim.RoleId);
            if (role == null) return NotFound("Không tìm thấy role");
            Input = new InputModel
            {
                ClaimType = claim.ClaimType,
                ClaimValue = claim.ClaimValue,
            };
            return Page();
        }
        public async Task<IActionResult> OnPost(int? claimid)
        {
            if (claimid == null)
                return NotFound("Không tìm thấy claim");
            claim = dbcontext.RoleClaims.FirstOrDefault(c => c.Id == claimid);
            if (claim == null)
                return NotFound("Không tìm thấy claim");
            role = await rolemanage.FindByIdAsync(claim.RoleId);
            if (role == null) return NotFound("Không tìm thấy role");
            if(!ModelState.IsValid)
                return Page();
            if( (dbcontext.RoleClaims.Where(c => c.RoleId == role.Id).ToList())
                .Any(c => c.Id != claim.Id && c.ClaimType == Input.ClaimType && c.ClaimValue == Input.ClaimValue))
            {
                ModelState.AddModelError(string.Empty, "Claim này đã có trong role");
                return Page();
            }
            claim.ClaimType = Input.ClaimType;
            claim.ClaimValue = Input.ClaimValue;
            dbcontext.RoleClaims.Update(claim);
            await dbcontext.SaveChangesAsync();
            StatusMessage = "Bạn vừa cập nhật claim";
            return RedirectToPage("./Edit", new {roleid = role.Id});

        }

        public async Task<IActionResult> OnPostDelete(int? claimid)
        {
            if (claimid == null)
                return NotFound("Không tìm thấy claim");
            claim = dbcontext.RoleClaims.FirstOrDefault(c => c.Id == claimid);
            if (claim == null)
                return NotFound("Không tìm thấy claim");
            role = await rolemanage.FindByIdAsync(claim.RoleId);
            if (role == null) return NotFound("Không tìm thấy role");

            //dbcontext.RoleClaims.Remove(claim);
            await rolemanage.RemoveClaimAsync(role, new System.Security.Claims.Claim(claim.ClaimType, claim.ClaimValue));
            await dbcontext.SaveChangesAsync();
            StatusMessage = "Bạn vừa xóa claim";
            return RedirectToPage("./Edit", new { roleid = role.Id });

        }
    }
}
