using NewProject.Application.Abstractions.IServices;
using NewProject.Domain.Entities.DTOs;
using NewProject.Domain.Entities.Models;
using System.Linq.Expressions;

namespace NewProject.Application.Services.UserServices
{
    public class UserService : IUserService
    {
        public Task<User> Create(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByAny(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<User> Update(int Id, UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
