using System;
using Domain.Entities;

namespace Infrastructure.Interfaces
{
    public interface ICategoryRepository
    {
        public Task<Category?> GetById(Guid Id);
        public Task<IEnumerable<Category>> GetAll();
        public Task<Guid> Create(Category category);
        public Task<bool> Update(Category category);
        public Task<bool> Delete(Guid Id);
    }
}
