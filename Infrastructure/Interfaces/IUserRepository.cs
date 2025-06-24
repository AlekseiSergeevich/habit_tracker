using System;
using Domain.Entities;

namespace Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetById(Guid id);
        Task<User?> GetByEmail(string email);
        Task<IEnumerable<User>> GetAll();
        Task<Guid> Create(User user);
        Task<bool> Update(User user);
        Task<bool> Delete(Guid id);
    }
}
