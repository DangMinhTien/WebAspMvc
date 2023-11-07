using Bai1_ChinhThuc.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Linq;

namespace Bai1_ChinhThuc.Areas.Admin.Pages.Users
{
    public class EditUserClaimModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDbContext _dbContext;

        public EditUserClaimModel(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            AppDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _dbContext = dbContext;
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
        [TempData]
        public string StatusMessage { get; set; }
        public AppUser user { get; set; }
        public IdentityUserClaim<string> userClaim { get; set; }
        public IActionResult OnGet()
        {
            return NotFound("Không thể truy cập");
        }
        public async Task<IActionResult> OnGetAddClaim(string userid)
        {
            if(userid == null)
            {
                return NotFound("Không tìm thấy user");
            }
            user = await _userManager.FindByIdAsync(userid);
            if(user == null)
            {
                return NotFound("Không tìm thấy user");
            }
            Input = new InputModel();
            return Page();
        }
        public async Task<IActionResult> OnPostAddClaim(string userid)
        {
            if (userid == null)
            {
                return NotFound("Không tìm thấy user bị null");
            }
            user = await _userManager.FindByIdAsync(userid);
            if (user == null)
            {
                return NotFound("Không tìm thấy user");
            }
            if(!ModelState.IsValid) { return Page(); }
            var claim = await _userManager.GetClaimsAsync(user);
            if(claim.Any(c => c.Type == Input.ClaimType && c.Value == Input.ClaimValue))
            {
                ModelState.AddModelError(string.Empty, "Claim này đã tồn tại trong user");
                return Page();
            }
            await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim(Input.ClaimType, Input.ClaimValue));
            _dbContext.SaveChanges();
            StatusMessage = "Đã thêm đặc tính";
            return RedirectToPage("./AddRole",new {userid = user.Id});
        }
        public async Task<IActionResult> OnGetEditClaim(int? claimid)
        {
            if (claimid == null) { return NotFound("Không tìm thấy claim"); }
            userClaim = _dbContext.UserClaims.FirstOrDefault(c => c.Id == claimid);
            if (userClaim == null) { return NotFound("Không tìm thấy claim"); }
            user = await _userManager.FindByIdAsync(userClaim.UserId);
            if (user == null)
            {
                return NotFound("Không tìm thấy user");
            }
            Input = new InputModel()
            {
                ClaimType = userClaim.ClaimType,
                ClaimValue = userClaim.ClaimValue,
            };
            return Page();
        }
        public async Task<IActionResult> OnPostEditClaim(int? claimid)
        {
            if (claimid == null) { return NotFound("Không tìm thấy claim"); }
            userClaim = _dbContext.UserClaims.FirstOrDefault(c => c.Id == claimid);
            if (userClaim == null) { return NotFound("Không tìm thấy claim"); }
            user = await _userManager.FindByIdAsync(userClaim.UserId);
            if (user == null)
            {
                return NotFound("Không tìm thấy user");
            }
            if (!ModelState.IsValid) { return Page(); }
            var claim = _dbContext.UserClaims.Where(c => c.UserId == user.Id).ToList();
            if (claim.Any(c => c.Id != userClaim.Id && c.ClaimType == Input.ClaimType && c.ClaimValue == Input.ClaimValue))
            {
                ModelState.AddModelError(string.Empty, "Claim này đã tồn tại trong user");
                return Page();
            }
            userClaim.ClaimValue = Input.ClaimValue;
            userClaim.ClaimType = Input.ClaimType;
            _dbContext.UserClaims.Update(userClaim);
            _dbContext.SaveChanges();
            StatusMessage = "Đã cập nhật claim xong";
            return RedirectToPage("./AddRole", new { userid = user.Id });
        }
        public async Task<IActionResult> OnPostDeleteClaim(int? claimid)
        {
            if (claimid == null) { return NotFound("Không tìm thấy claim"); }
            userClaim = _dbContext.UserClaims.FirstOrDefault(c => c.Id == claimid);
            if (userClaim == null) { return NotFound("Không tìm thấy claim"); }
            user = await _userManager.FindByIdAsync(userClaim.UserId);
            if (user == null)
            {
                return NotFound("Không tìm thấy user");
            }
            _dbContext.UserClaims.Remove(userClaim);
            _dbContext.SaveChanges();
            StatusMessage = "Đã xóa claim của user";
            return RedirectToPage("./AddRole", new { userid = user.Id });
        }
    }
}
