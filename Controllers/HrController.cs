using Microsoft.AspNetCore.Mvc;

namespace NewDms.Controllers
{
    public class HrController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
