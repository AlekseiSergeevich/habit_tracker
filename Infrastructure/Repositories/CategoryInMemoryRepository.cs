using System;
using Domain.Entities;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categories;

        public CategoryInMemoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category{Id = Guid.NewGuid(), Name = "Спорт", Color = "#008000"},
                new Category{Id = Guid.NewGuid(), Name = "Вредная привычка", Color = "#FF0000"},
                new Category{Id = Guid.NewGuid(), Name = "Отдых", Color = "#8B00FF"}
            };
        }
        public Task<Guid> Create(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));
            _categories.Add(category);
            return Task.FromResult(category.Id);
        }

        public Task<bool> Delete(Guid Id)
        {
            var category = _categories.FirstOrDefault(x => x.Id.Equals(Id));
            if (category == null)
                return Task.FromResult(false);

            _categories.Remove(category);
            return Task.FromResult(true);
        }

        public Task<IEnumerable<Category>> GetAll()
        {
            return Task.FromResult(_categories.AsEnumerable());
        }

        public Task<Category?> GetById(Guid Id)
        {
            var category = _categories.FirstOrDefault(x => x.Id.Equals(Id));
            return Task.FromResult(category);
        }

        public Task<bool> Update(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            var old_category = _categories.FirstOrDefault(u => u.Id.Equals(category.Id));

            if (old_category == null)
                return Task.FromResult(false);
            
            old_category.Name = category.Name;
            old_category.Color = category.Color;
            return Task.FromResult(true);
        }
    }
}
