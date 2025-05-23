using Microsoft.AspNetCore.Mvc;
using Tour_Guide_Api.Abstractions;

namespace Tour_Guide_Api.Controllers;

[ApiController]
[Route("[controller]")]
public class EmailController : ControllerBase
{
    [HttpPost("send")]
    public async Task<bool> Send(
        [FromServices] IEmailService emailService,
        [FromForm] string to)
    {
        await emailService.SendAsync(to, "Привет!", "Привет!");
        return true;
    }
}