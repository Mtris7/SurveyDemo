using Microsoft.EntityFrameworkCore;
using test.Entities;

namespace test.EF
{
    public class SurveyDbContext : DbContext
    {
        public SurveyDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Survey> Survey { get; set; }
    }
}
