using System;

namespace Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Color { get; set; }
    }
}
