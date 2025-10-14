using Microsoft.AspNetCore.Mvc;

namespace NewDms.Controllers
{
    public class OperationController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
