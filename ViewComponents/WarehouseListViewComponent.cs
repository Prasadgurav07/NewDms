using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using NewDms.Repositories;

namespace NewDms.ViewComponents
{
    public class WarehouseListViewComponent : ViewComponent
    {

        private WarehouseRepo _warehouseRepo;

        public WarehouseListViewComponent()
        {
            _warehouseRepo = new WarehouseRepo();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_warehouseRepo.getWarehouseList()); // renders Default.cshtml by default
        }
    }
}
