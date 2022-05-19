using Microsoft.EntityFrameworkCore;

namespace InspectionAPI.Data
{
    public class DataContext : DbContext
    {
        //constructor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<InspectionType> InspectionTypes { get; set; }

        public DbSet<Status> Statuses { get; set; }
    }
}
