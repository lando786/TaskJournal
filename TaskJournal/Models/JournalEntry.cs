using TaskJournal.Enums;

namespace TaskJournal.Models;

public class JournalEntry
{
    public Guid Id { get; set; }
    public DateTime Time { get; set; }
    public TaskType Type { get; set; }
    public TaskDescription Description { get; set; }
}