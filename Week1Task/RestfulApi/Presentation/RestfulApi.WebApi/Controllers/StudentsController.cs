using Microsoft.AspNetCore.Mvc;

namespace RestfulApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Student()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Student([FromBody] string a)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Student(int a)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Student(int a, int b)
        {
            return Ok();
        }

        [HttpPatch]
        public IActionResult Student(int a, int b, int c)
        {
            return Ok();
        }
    }
}
