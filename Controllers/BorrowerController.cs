using Microsoft.AspNetCore.Mvc;

namespace NewDms.Controllers
{
    public class BorrowerController : Controller
    {
        public IActionResult Index()
        {
            return PartialView("Index");
        }
    }
}
