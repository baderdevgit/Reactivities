using Microsoft.EntityFrameworkCore;
using Domain;
using Domain.obj;


namespace Persistence
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            //leave this empty
        }

        public DbSet<Activity> Activities { get; set; }
    }
}