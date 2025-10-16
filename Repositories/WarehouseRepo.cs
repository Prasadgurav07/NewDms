using NewDms.Models;

namespace NewDms.Repositories
{
    public class WarehouseRepo
    {
        public List<Warehouse> getWarehouseList()
        {
            var wlist= new List<Warehouse>();

            List<Emplyoee> ccms= new List<Emplyoee>();  
            ccms.Add(new Emplyoee() { Id=1213,Name="CCM1",Designation="CCM"});
            ccms.Add(new Emplyoee() { Id = 1243, Name = "CCM2", Designation = "CCM" });

            wlist.Add(new Warehouse() { warehouse_id=1, warehouse_name="ABC", pendings_approvals="12" ,CCM = ccms });
            wlist.Add(new Warehouse() { warehouse_id = 2, warehouse_name = "SHH", pendings_approvals = "10" , CCM = ccms });
            return wlist;
        }
    }
}
