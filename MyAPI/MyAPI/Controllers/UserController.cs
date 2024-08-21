using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers
{
   
    public class UserController : BaseAPIController
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok();
        }
        
    }
}
