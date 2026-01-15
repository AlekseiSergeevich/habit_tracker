using System;

namespace Application.DTO
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Color { get; set; }
    }
}
