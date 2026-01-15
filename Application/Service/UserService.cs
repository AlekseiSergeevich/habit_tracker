using System;
using Application.DTO;

namespace Application.Service
{
    public class UserService : IUserService
    {
        public Task Add(UserDto user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(UserDto user)
        {
            throw new NotImplementedException();
        }
    }
}
