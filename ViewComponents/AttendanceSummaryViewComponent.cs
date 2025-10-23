using Microsoft.AspNetCore.Mvc;
using NewDms.Data;
using NewDms.Models;
using NewDms.Repositories;

namespace NewDms.ViewComponents
{
    public class AttendanceSummaryViewComponent:ViewComponent
    {


        private ReportSummaryRepo _summaryRepo;

        public AttendanceSummaryViewComponent(IConfiguration configuration)
        {
            _summaryRepo = new ReportSummaryRepo(configuration.GetConnectionString("DefaultConnection"));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            ReportSummary sm = _summaryRepo.GetAllReports();
            return View(sm);// renders Default.cshtml by default
        }

    }
}
