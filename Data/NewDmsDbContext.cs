using Microsoft.EntityFrameworkCore;

namespace NewDms.Data
{
    public class NewDmsDbContext : DbContext
    {
        public NewDmsDbContext(DbContextOptions<NewDmsDbContext> options):base(options) 
        {
        }


    }
}
