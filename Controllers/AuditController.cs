using Microsoft.AspNetCore.Mvc;

namespace NewDms.Controllers
{
    public class AuditController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
