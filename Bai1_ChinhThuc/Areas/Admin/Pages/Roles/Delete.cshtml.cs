using Bai1_ChinhThuc.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bai1_ChinhThuc.Areas.Admin.Pages.Roles
{
    public class DeleteModel : RolePageModel
    {
        public DeleteModel(RoleManager<IdentityRole> _rolemanage, AppDbContext _dbcontext) : base(_rolemanage, _dbcontext)
        {

        }
       
        public IdentityRole role { get; set; }
        public async Task<IActionResult> OnGet(string roleid)
        {
            if(roleid == null)
            {
                return NotFound("Không tìm thấy role");
            }
            
            role = await rolemanage.FindByIdAsync(roleid);
            if(role != null)
            {
                return Page();
            }
            return NotFound("Không tìm thấy role");
        }
        public async Task<IActionResult> OnPostAsync(string roleid)
        {
            if (roleid == null)
            {
                return NotFound();
            }
            role = await rolemanage.FindByIdAsync(roleid);
            if(role == null) 
            {
                return NotFound();
            }
            var result = await rolemanage.DeleteAsync(role);
            if(result.Succeeded)
            {
                StatusMessage = $"Bạn vừa xóa role {role.Name}";
                return RedirectToPage("./Index");
            }
            else
            {
                result.Errors.ToList().ForEach(error =>
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                });
            }
            return Page();
        }
    }
}
