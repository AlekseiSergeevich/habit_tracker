using System;

namespace Application.DTO
{
    public class HabitDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public Guid? UserId { get; set; }
        public Guid? RecordsId { get; set; } = new();
        public Guid? CategoryId { get; set; }
    }
}
