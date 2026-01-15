using System;
using Domain.Entities;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories
{
    public class HabitInMemoryRepository : IHabitRepository
    {
        private readonly List<Habit> _habits;
        public HabitInMemoryRepository()
        {
            _habits = new List<Habit>()
            {
                new Habit{Id = Guid.Parse("12345"), Name = "Приседания по утрам"},
                new Habit{Id = Guid.Parse("23456"), Name = "Отжимания по утрам"},
                new Habit{Id = Guid.Parse("34567"), Name = "Отказ от курения"}
            };
        }
        public Task<Habit?> GetById(Guid id)
        {
            var habit = _habits.FirstOrDefault(x => x.Id.Equals(id));
            return Task.FromResult(habit);
        }

        public Task<IEnumerable<Habit>> GetAll()
        {
            return Task.FromResult(_habits.AsEnumerable());
        }

        public Task<Guid> Create(Habit habit)
        {
            if (habit == null)
                throw new ArgumentNullException(nameof(habit));
            _habits.Add(habit);
            return Task.FromResult(habit.Id);
        }

        public Task<bool> Update(Habit habit)
        {
            if (habit == null)
                throw new ArgumentNullException(nameof(habit));

            var old_habit = _habits.FirstOrDefault(u => u.Id.Equals(habit.Id));

            if (old_habit == null)
                return Task.FromResult(false);

            old_habit.Name = habit.Name;
            old_habit.CategoryId = habit.CategoryId;
            old_habit.UserId = habit.UserId;
            old_habit.RecordsId = habit.RecordsId;
            return Task.FromResult(true);
        }

        public Task<bool> Delete(Guid Id)
        {
            var habit = _habits.FirstOrDefault(x => x.Id.Equals(Id));
            if (habit == null)
                return Task.FromResult(false);

            _habits.Remove(habit);
            return Task.FromResult(true);
        }

        public Task DeleteByUserId(Guid ownerId)
        {
            throw new NotImplementedException();
        }
        public Task DeleteByCategoryId(Guid categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
