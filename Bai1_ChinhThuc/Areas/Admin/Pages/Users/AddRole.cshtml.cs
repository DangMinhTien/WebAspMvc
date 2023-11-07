using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Bai1_ChinhThuc.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Bai1_ChinhThuc.Areas.Admin.Pages.Users
{
    public class AddRoleModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDbContext _dbContext;

        public AddRoleModel(
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

        [TempData]
        public string StatusMessage { get; set; }
        [BindProperty]
        [DisplayName("Các vai trò của user")]
        public string[] RoleNames { get; set; }

        public SelectList allRole { get; set; }
        public AppUser user { get; set; }

        public List<IdentityRoleClaim<string>> ClaimInRole { get; set; }
        public List<IdentityUserClaim<string>> ClaimInUser { get; set; }
        public async Task<IActionResult> OnGetAsync(string userid)
        {
            if(String.IsNullOrEmpty(userid))
                return NotFound("Không có user");

            user = await _userManager.FindByIdAsync(userid);
            if (user == null)
            {
                return NotFound($"Không tìn thấy user có id = {userid}.");
            }
            List<string> _roleName = await _roleManager.Roles.Select(r => r.Name).ToListAsync<string>();
            allRole = new SelectList(_roleName);
            //Lấy các role cũ củ user
            RoleNames = (await _userManager.GetRolesAsync(user)).ToArray<string>();

            GetClaims(user.Id);

            return Page();
        }
        public void GetClaims(string userId)
        {
            var listRole = (from _r in _dbContext.Roles
                            join _ur in _dbContext.UserRoles on _r.Id equals _ur.RoleId
                            where _ur.UserId == userId
                            select _r).ToList();
            var listRoleClaim = from _r in listRole
                            join _rc in _dbContext.RoleClaims on _r.Id equals _rc.RoleId
                            select _rc;
            ClaimInRole = listRoleClaim.ToList();

            var listUserClaim = from _uc in _dbContext.UserClaims
                                where _uc.UserId == userId
                                select _uc;
            ClaimInUser = listUserClaim.ToList();
        }
        public async Task<IActionResult> OnPostAsync(string userid)
        {
            if (String.IsNullOrEmpty(userid))
                return NotFound("Không có user");

            user = await _userManager.FindByIdAsync(userid);

            if (user == null)
            {
                return NotFound($"Không tìn thấy user có id = {userid}.");
            }
            GetClaims(user.Id);
            if (!ModelState.IsValid)
            {
                List<string> _roleName = await _roleManager.Roles.Select(r => r.Name).ToListAsync<string>();
                allRole = new SelectList(_roleName);
                //Lấy các role cũ củ user
                RoleNames = (await _userManager.GetRolesAsync(user)).ToArray<string>();
                return Page();
            }
            var OldRoleNames = (await _userManager.GetRolesAsync(user)).ToArray<string>();
            var deleteRole = OldRoleNames.Where(r => !RoleNames.Contains(r));
            var addRoles = RoleNames.Where(r => !OldRoleNames.Contains(r));
            var resultdelete = await _userManager.RemoveFromRolesAsync(user, deleteRole);
            if (!resultdelete.Succeeded)
            {
                resultdelete.Errors.ToList().ForEach(error =>
                {
                    ModelState.AddModelError(String.Empty, error.Description);
                });
                List<string> _roleName = await _roleManager.Roles.Select(r => r.Name).ToListAsync<string>();
                allRole = new SelectList(_roleName);
                //Lấy các role cũ củ user
                RoleNames = (await _userManager.GetRolesAsync(user)).ToArray<string>();
                return Page();
            }
            var resultAdd = await _userManager.AddToRolesAsync(user, addRoles);
            if (!resultAdd.Succeeded)
            {
                resultAdd.Errors.ToList().ForEach(error =>
                {
                    ModelState.AddModelError(String.Empty, error.Description);
                });
                List<string> _roleName = await _roleManager.Roles.Select(r => r.Name).ToListAsync<string>();
                allRole = new SelectList(_roleName);
                //Lấy các role cũ củ user
                RoleNames = (await _userManager.GetRolesAsync(user)).ToArray<string>();
                return Page();
            }
            StatusMessage = $"Đã thêm vai trò cho user {user.UserName}.";

            return RedirectToPage("./Index");
            /*
            if (!addPasswordResult.Succeeded)
            {
                foreach (var error in addPasswordResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return Page();
            }

            StatusMessage = $"Mật khẩu của user {user.UserName} đã được đặt lại.";

            return RedirectToPage("./Index");
            */
        }
    }
}
