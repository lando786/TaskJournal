using TaskJournal.Enums;

namespace TaskJournal.DTOs;

public class PostTaskRequest
{
    public Guid PersonId { get; set; }
    public TaskType TaskType { get; set; }
    public DateTime DateTime { get; set; }
    public TaskDescription Description { get; set; }
}