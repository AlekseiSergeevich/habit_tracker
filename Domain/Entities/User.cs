using System;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public string? PasswordHash { get; set; }
        public Guid? HabitsId { get; set; }
    }
}
