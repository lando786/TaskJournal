namespace TaskJournal.Models;

public class ReportPage
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public Person Person { get; set; }
    public IEnumerable<JournalEntry> Tasks { get; set; }
}