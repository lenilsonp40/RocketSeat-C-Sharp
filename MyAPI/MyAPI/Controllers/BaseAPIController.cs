using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseAPIController : ControllerBase
    {
        [HttpGet("heathy")]
        public IActionResult Heathy()
        {
            return Ok("It´s working");
        }
    }
}
