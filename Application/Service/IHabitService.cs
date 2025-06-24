using System;
using Application.DTO;

namespace Application.Service
{
    public interface IHabitService
    {
        public Task Add(HabitDto habit);
        public Task<bool> Delete(Guid id);
        public Task<HabitDto> GetById(Guid id);
        public Task<HabitDto> GetByUserId(Guid id);
        public Task<HabitDto> GetByRecordId(Guid id);
        public Task<HabitDto> GetByCategoryId(Guid id);
        public Task<IEnumerable<HabitDto>> GetAll();
        public Task<bool> Update(HabitDto habit);
    }
}
