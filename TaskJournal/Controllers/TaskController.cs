using Microsoft.AspNetCore.Mvc;

namespace TaskJournal.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> PostTask()
    {
        return Ok();
    }
}