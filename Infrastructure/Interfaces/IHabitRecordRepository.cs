using System;
using Domain.Entities;

namespace Infrastructure.Interfaces
{
    public interface IHabitRecordRepository
    {
        public Task<HabitRecord?> GetById(Guid id);
        public Task<IEnumerable<HabitRecord>> GetAll();
        public Task<Guid> Create(HabitRecord habit);
        public Task<bool> Update(HabitRecord habit);
        public Task<bool> Delete(Guid id);
        public Task<HabitRecord?> DeleteByHabit(Guid habitId);
    }
}
