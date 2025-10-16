namespace NewDms.Models
{
    public class Warehouse
    {

        public int warehouse_id { get; set; }
        public string warehouse_name { get; set; }
        public string pendings_approvals { get; set; }
        public List<Emplyoee> CCM {  get; set; }

        


    }
}
