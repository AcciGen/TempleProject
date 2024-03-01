using Microsoft.EntityFrameworkCore;
using NewProject.Domain.Entities.Models;

namespace NewProject.Infrastructure.Persistance
{
    public class NewProjectDbContext : DbContext
    {
        public NewProjectDbContext(DbContextOptions<NewProjectDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
