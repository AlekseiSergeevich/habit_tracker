using System;
using Application.DTO;

namespace Application.Service
{
    public interface ICategoryService
    {
        public Task Add(CategoryDto category);
        public Task<bool> Delete(Guid id);
        public Task<CategoryDto> GetById(Guid Id);
        public Task<IEnumerable<CategoryDto>> GetAll();
        public Task<bool> Update(CategoryDto category);
    }
}
