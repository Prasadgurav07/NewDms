using Microsoft.AspNetCore.Mvc;

namespace NewDms.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
