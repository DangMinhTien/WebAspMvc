using Bai1_ChinhThuc.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Bai1_ChinhThuc.Areas.Admin.Pages.Roles
{
    public class RolePageModel : PageModel
    {
        protected readonly RoleManager<IdentityRole> rolemanage;
        protected readonly AppDbContext dbcontext;
        [TempData]
        public string StatusMessage { get; set; }
        
        public RolePageModel(RoleManager<IdentityRole> _rolemanage, AppDbContext _dbcontext)
        {
            rolemanage= _rolemanage;
            dbcontext= _dbcontext;
        }
    }
}
