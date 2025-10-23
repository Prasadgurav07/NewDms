using Microsoft.AspNetCore.Mvc;
using NewDms.Data;
using NewDms.Models;
using NewDms.Repositories;

namespace NewDms.Controllers
{
    public class OperationController : Controller
    {

        private WarehouseRepo _warehouseRepo;
        private ReportSummaryRepo _summaryRepo;

        public OperationController(IConfiguration iconfiguration)
        {
            _warehouseRepo = new WarehouseRepo();
            _summaryRepo = new ReportSummaryRepo(iconfiguration.GetConnectionString("DefaultConnection"));
        }

        public IActionResult Dashboard(int i)
        {

        
            ReportSummary sm =_summaryRepo.GetAllReports();
            return View(sm);
        }
    }
}
