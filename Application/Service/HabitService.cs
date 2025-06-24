using System;
using Application.DTO;

namespace Application.Service
{
    public class HabitService : IHabitService
    {
        public Task Add(HabitDto habit)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HabitDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<HabitDto> GetByCategoryId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<HabitDto> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<HabitDto> GetByRecordId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<HabitDto> GetByUserId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(HabitDto habit)
        {
            throw new NotImplementedException();
        }
    }
}
