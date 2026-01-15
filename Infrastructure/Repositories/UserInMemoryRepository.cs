using System;
using Domain.Entities;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories
{
    public class UserInMemoryRepository: IUserRepository
    {
        private readonly List<User> _users;
        public UserInMemoryRepository()
        {
            _users = new List<User>()
            {
                new User{Id = Guid.NewGuid(), FullName = "Jack Green", Email = "papapu@gmail.com", PhoneNumber = "823124"},
                new User{Id = Guid.NewGuid(), FullName = "Peter Parker", Email = "papa3321@gmail.com", PhoneNumber = "83428"},
                new User{Id = Guid.NewGuid(), FullName = "Alexey Alexandrov", Email = "alex2321@gmail.com", PhoneNumber = "882492"}
            };
        }
        public Task<User?> GetById(Guid id)
        {
            var user = _users.FirstOrDefault(x => x.Id.Equals(id));
            return Task.FromResult(user);
        }

        public Task<IEnumerable<User>> GetAll()
        {
            return Task.FromResult(_users.AsEnumerable());
        }

        public Task<Guid> Create(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));
            _users.Add(user);
            return Task.FromResult(user.Id);
        }

        public Task<bool> Update(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            var old_user = _users.FirstOrDefault(u => u.Id.Equals(user.Id));

            if (old_user == null)
                return Task.FromResult(false);

            old_user.PhoneNumber = user.PhoneNumber;
            old_user.Email = user.Email;
            old_user.FullName = user.FullName;
            old_user.HabitsId = user.HabitsId;
            return Task.FromResult(true);
        }

        public Task<bool> Delete(Guid Id)
        {
            var user = _users.FirstOrDefault(x => x.Id.Equals(Id));
            if (user == null)
                return Task.FromResult(false);

            _users.Remove(user);
            return Task.FromResult(true);
        }

        public Task<User?> GetByEmail(string email)
        {
            var user = _users.FirstOrDefault(x => x.Email == email);
            return Task.FromResult(user);
        }
    }
}
