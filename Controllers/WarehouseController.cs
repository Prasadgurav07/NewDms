using Microsoft.AspNetCore.Mvc;
using NewDms.Repositories;

namespace NewDms.Controllers
{
    public class WarehouseController : Controller
    {

        private WarehouseRepo _warehouseRepo;

        public WarehouseController()
        {
            _warehouseRepo = new WarehouseRepo();
        }

        public IActionResult Index()
        {
            var wlist=_warehouseRepo.getWarehouseList();
            return View(wlist);
        }
    }
}
