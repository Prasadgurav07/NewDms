namespace NewDms.Models
{


    public class Summary
    {
        public List<StateSummary> statewise;
        public List<WarehouseSummary> warehousewise;
        public List<CCMSummary> CCMwise;

        public Summary(List<StateSummary> statewise, List<WarehouseSummary> warehousewise, List<CCMSummary> cCMwise)
        {
            this.statewise = statewise;
            this.warehousewise = warehousewise;
            CCMwise = cCMwise;
        }
    }
    public class StateSummary
    {
        public string state {  get; set; }
        public List<Warehouse> Warehouse { get; set; }

    }

    public class WarehouseSummary
    {
        public string state { get; set; }
        public List<Warehouse> Warehouse { get; set; }

    }


    public class CCMSummary
    {
        public string state { get; set; }
        public List<Warehouse> Warehouse { get; set; }

    }
}
