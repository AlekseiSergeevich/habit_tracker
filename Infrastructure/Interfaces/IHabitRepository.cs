using System;
using Domain.Entities;

namespace Infrastructure.Interfaces
{
    public interface IHabitRepository
    {
        public Task<Habit?> GetById(Guid id);
        public Task<IEnumerable<Habit>> GetAll();
        public Task<Guid> Create(Habit habit);
        public Task<bool> Update(Habit habit);
        public Task<bool> Delete(Guid id);
        public Task<Habit?> DeleteByUserId(Guid ownerId);
        public Task<Habit?> DeleteByCategoryId(Guid categoryId);
        
    }
}
