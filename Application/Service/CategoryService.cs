using System;
using Application.DTO;

namespace Application.Service
{
    public class CategoryService : ICategoryService
    {
        public Task Add(CategoryDto category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(CategoryDto category)
        {
            throw new NotImplementedException();
        }
    }
}
