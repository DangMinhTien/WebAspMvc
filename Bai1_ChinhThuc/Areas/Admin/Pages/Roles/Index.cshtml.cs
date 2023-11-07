using Bai1_ChinhThuc.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai1_ChinhThuc.Areas.Admin.Pages.Roles
{
    [Authorize]
    public class IndexModel : RolePageModel
    {
        public class RoleModel : IdentityRole
        {
            public string[] Claims { get; set; }
        }
        public List<RoleModel> roles { get; set; }
        public IndexModel(RoleManager<IdentityRole> _rolemanage, AppDbContext _dbcontext): base(_rolemanage, _dbcontext)
        {
            
        }
        public async Task OnGet()
        {
            var r = await rolemanage.Roles.ToListAsync();
            roles = new List<RoleModel>();
            foreach (var _r in r) 
            {
                var claims = await rolemanage.GetClaimsAsync(_r);
                var ClaimsString = claims.Select(c => c.Type + " = " + c.Value );
                var role = new RoleModel
                {
                    Id = _r.Id,
                    Name = _r.Name,
                    Claims = ClaimsString.ToArray()
                };
                roles.Add(role);
            }
        }
        public void OnPost()
        {
           RedirectToPage();
        }
    }
}
