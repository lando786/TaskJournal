using Microsoft.EntityFrameworkCore;

namespace TaskJournal.Models;

public class TaskJournalContext: DbContext
{
    private readonly IConfiguration _configuration;
    public DbSet<Person> Persons { get; set; }
    public DbSet<JournalEntry> JournalEntries { get; set; }

    public TaskJournalContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Database"));
    }
}