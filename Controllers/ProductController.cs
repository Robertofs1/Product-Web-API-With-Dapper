
using Microsoft.AspNetCore.Mvc;

namespace dotnet_dapper.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(){
            return Ok("works");
        }
    }
}