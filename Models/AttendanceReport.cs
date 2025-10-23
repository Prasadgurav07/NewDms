namespace NewDms.Models
{
    public class AttendanceReport
    {
        public string State { get; set; }
        public string SH { get; set; }
        public string AHM { get; set; }
        public string HM { get; set; }
        public string CCM { get; set; }

        public Warehouse Warehouse { get; set; }
    }
}
