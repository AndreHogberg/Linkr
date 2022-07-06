using Microsoft.AspNetCore.Mvc;

namespace Linkr.Controllers;
[ApiController]
public class LinkController : ControllerBase
{
    [HttpGet("r/{slug}")]
    public async ValueTask<IActionResult> LinkrRedirect(string slug)
    {
        return Redirect("http://www.google.com");
    }
}