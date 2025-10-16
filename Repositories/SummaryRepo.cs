using NewDms.Models;

namespace NewDms.Repositories
{
    public class SummaryRepo
    {
        private WarehouseRepo _warehouseRepo;

        public SummaryRepo()
        {
            _warehouseRepo = new WarehouseRepo();
        }

        public List<StateSummary> getSummarybystate()
        {
            var slist = new List<StateSummary>();
            slist.Add(new StateSummary() { state = "maharashtra", Warehouse = _warehouseRepo.getWarehouseList() });
            slist.Add(new StateSummary() { state = "Goa", Warehouse = _warehouseRepo.getWarehouseList() }); 
            return slist;
        }

        public List<WarehouseSummary> getSummarybywarehouse()
        {
            var wlist = new List<WarehouseSummary>();
            wlist.Add(new WarehouseSummary() { state = "maharashtra", Warehouse = _warehouseRepo.getWarehouseList() });
            wlist.Add(new WarehouseSummary() { state = "Goa", Warehouse = _warehouseRepo.getWarehouseList() });
            return wlist;
        }


        public List<CCMSummary> getSummarybyCCM()
        {
            var clist = new List<CCMSummary>();
            clist.Add(new CCMSummary() { state = "maharashtra", Warehouse = _warehouseRepo.getWarehouseList() });
            clist.Add(new CCMSummary() { state = "Goa", Warehouse = _warehouseRepo.getWarehouseList() });
            return clist;
        }

    }
}
