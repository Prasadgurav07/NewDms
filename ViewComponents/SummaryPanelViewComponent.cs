using Microsoft.AspNetCore.Mvc;
using NewDms.Models;
using NewDms.Repositories;

namespace NewDms.ViewComponents
{
    public class SummaryPanelViewComponent:ViewComponent
    {


        private SummaryRepo _summaryRepo;

        public SummaryPanelViewComponent()
        {
            _summaryRepo = new SummaryRepo();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var slist = _summaryRepo.getSummarybystate();
            var wlist = _summaryRepo.getSummarybywarehouse();
            var clist = _summaryRepo.getSummarybyCCM();

            Summary sm = new Summary(slist, wlist, clist);
            return View(sm);// renders Default.cshtml by default
        }
    }
}
