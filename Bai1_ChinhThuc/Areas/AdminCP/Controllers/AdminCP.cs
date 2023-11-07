using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bai1_ChinhThuc.Areas.AdminCP.Controllers
{
    [Area("AdminCP")]
    [Authorize(Roles = "Admin")]
    public class AdminCP : Controller
    {
        [Route("/admincp")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
