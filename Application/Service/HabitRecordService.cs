using System;
using Application.DTO;

namespace Application.Service
{
    public class HabitRecordService : IHabitRecordService
    {
        public Task Add(HabitRecordDto record)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HabitRecordDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<HabitRecordDto> GetByHabitId(Guid habitId)
        {
            throw new NotImplementedException();
        }

        public Task<HabitRecordDto> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(HabitRecordDto record)
        {
            throw new NotImplementedException();
        }
    }
}
