using System;
using Domain.Entities;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories
{
    public class HabitRecordInMemoryRepository : IHabitRecordRepository
    {
        private readonly List<HabitRecord> _habit_records;
        public HabitRecordInMemoryRepository()
        {
            _habit_records = new List<HabitRecord>()
            {
                new HabitRecord{Id = Guid.NewGuid(), HabitId = Guid.Parse("12345"), Date = DateTime.Now, IsCompleted =true},
                new HabitRecord{Id = Guid.NewGuid(), HabitId = Guid.Parse("23456"), Date = DateTime.Now, IsCompleted =false},
                new HabitRecord{Id = Guid.NewGuid(), HabitId = Guid.Parse("34567"), Date = DateTime.Now, IsCompleted =true}
            };
        }
        public Task<Guid> Create(HabitRecord record)
        {
            if (record == null)
                throw new ArgumentNullException(nameof(record));
            _habit_records.Add(record);
            return Task.FromResult(record.Id);
        }

        public Task<bool> Delete(Guid id)
        {
            var record = _habit_records.FirstOrDefault(x => x.Id.Equals(id));
            if (record == null)
                return Task.FromResult(false);

            _habit_records.Remove(record);
            return Task.FromResult(true);
        }

        public Task DeleteByHabit(Guid habitId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HabitRecord>> GetAll()
        {
            return Task.FromResult(_habit_records.AsEnumerable());
        }

        public Task<HabitRecord?> GetById(Guid id)
        {
            var record = _habit_records.FirstOrDefault(x => x.Id.Equals(id));
            return Task.FromResult(record);
        }

        public Task<bool> Update(HabitRecord record)
        {
            if (record == null)
                throw new ArgumentNullException(nameof(record));

            var old_record = _habit_records.FirstOrDefault(u => u.Id.Equals(record.Id));

            if (old_record == null)
                return Task.FromResult(false);

            old_record.HabitId = record.HabitId;
            old_record.Comment = record.Comment;
            old_record.CompletionTime = record.CompletionTime;
            old_record.Date = record.Date;
            old_record.IsCompleted = record.IsCompleted;
            return Task.FromResult(true);
        }
    }
}
