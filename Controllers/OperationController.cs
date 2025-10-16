using Microsoft.AspNetCore.Mvc;
using NewDms.Models;
using NewDms.Repositories;

namespace NewDms.Controllers
{
    public class OperationController : Controller
    {

        private WarehouseRepo _warehouseRepo;
        private SummaryRepo _summaryRepo;

        public OperationController()
        {
            _warehouseRepo = new WarehouseRepo();
            _summaryRepo = new SummaryRepo();
        }

        public IActionResult Dashboard(int i)
        {

            var slist = _summaryRepo.getSummarybystate();
            var wlist=_summaryRepo.getSummarybywarehouse();
            var clist=_summaryRepo.getSummarybyCCM();
            ViewBag.i = i;  
            Summary sm = new Summary(slist,wlist,clist);
            return View(sm);
        }
    }
}
