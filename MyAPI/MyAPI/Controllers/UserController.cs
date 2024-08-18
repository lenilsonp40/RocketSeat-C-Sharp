using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {


            return Ok();
        }

    }
}
