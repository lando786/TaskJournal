using Microsoft.AspNetCore.Mvc;
using TaskJournal.DTOs;
using TaskJournal.Models;

namespace TaskJournal.Controllers;
[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly TaskJournalContext _dbContext;

    public PersonController(TaskJournalContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    public async Task<IActionResult> PostPerson(PersonRequest request)
    {
        var added = await _dbContext.AddAsync(new Person()
        {
            FirstName = request.FirstName,
            LastName = request.LastName
        });
        await _dbContext.SaveChangesAsync();
        return Ok(added);
    }
}