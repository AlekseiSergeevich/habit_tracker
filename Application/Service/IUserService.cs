using System;
using Application.DTO;

namespace Application.Service
{
    public interface IUserService
    {
        public Task Add(UserDto user);
        public Task<bool> Delete(Guid id);
        public Task<UserDto> GetById(Guid Id);
        public Task<IEnumerable<UserDto>> GetAll();
        public Task<bool> Update(UserDto user);
    }
}
