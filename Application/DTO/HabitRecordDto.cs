using System;

namespace Application.DTO
{
    public class HabitRecordDto
    {
        public Guid Id { get; set; }
        public Guid HabitId { get; set; }
        public DateTime Date { get; set; }
        public bool IsCompleted { get; set; }
        public string? Comment { get; set; }
        public TimeSpan? CompletionTime { get; set; }
    }
}
