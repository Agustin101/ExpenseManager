using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{

    [HttpGet]
    public async Task<ActionResult> Test(bool error)
    {
        
        return Ok(new
        {
            mensaje = "No error"
        });
    }
}