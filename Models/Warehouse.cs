namespace NewDms.Models
{
    public class Warehouse
    {

        public int warehouse_id { get; set; }
        public string state { get; set; }
        public string Location { get; set; }
        public string warehouse_name { get; set; }
        public string pendings_approvals { get; set; }
        public List<Emplyoee> CCM {  get; set; }

        public List<Stock> stocks { get; set; }
      

    }
}
