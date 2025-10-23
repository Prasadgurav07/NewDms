using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NewDms.Data;
using NewDms.Models;
using System.Data;
using System.Data.Common;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace NewDms.Repositories
{
    public class ReportSummaryRepo
    {
        private WarehouseRepo _warehouseRepo;
        private string _dbconn;

        public ReportSummaryRepo(string _dbconn)
        {
            _warehouseRepo = new WarehouseRepo();
            this._dbconn = _dbconn;
        }

        public ReportSummary GetAllReports()
        {
            List<StockReport> sr = new List<StockReport>();
            List<AttendanceReport> ar = new List<AttendanceReport>();

            DataTable dt = new DataTable();
            try
            {
              
                using (SqlConnection sqlConnection = new SqlConnection(_dbconn))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_performancebasedmis", sqlConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userid", 1);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }

                        foreach (DataRow row in dt.Rows)
                        {

                            var item = new StockReport()
                            {
                                
                                State = row["State"]?.ToString(),
                                SH = row["State_Head"]?.ToString(),
                                HM = row["hm"]?.ToString(),
                                AHM = row["ahm"]?.ToString(),
                                CCM = row["CCM"]?.ToString(),
                                CM = row["CollateralManager"]?.ToString(),
                                _Warehousename = row["WarehouseName"]?.ToString(),
                                wstock = 10000

                            };
                            //Console.WriteLine(item.State);

                            sr.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle exception properly
                Console.WriteLine("Error: " + ex.Message);
            }



            return new ReportSummary()
            {
                _StockReport = sr,
                _AttendanceReport = null

            };

        }
    }
       
}
