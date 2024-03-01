using Microsoft.EntityFrameworkCore;
using NewProject.Application.Abstractions;
using NewProject.Domain.Entities.Models;
using NewProject.Infrastructure.Persistance;

namespace NewProject.Infrastructure.BaseRepositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(NewProjectDbContext context, DbSet<User> dbSet) : base(context, dbSet)
        {
        }
    }
}
