using System;
using Application.DTO;

namespace Application.Service
{
    public interface IHabitRecordService
    {
        public Task Add(HabitRecordDto record);
        public Task<bool> Delete(Guid id);
        public Task<HabitRecordDto> GetById(Guid id);
        public Task<HabitRecordDto> GetByHabitId(Guid habitId);
        public Task<IEnumerable<HabitRecordDto>> GetAll();
        public Task<bool> Update(HabitRecordDto record);

    }
}
