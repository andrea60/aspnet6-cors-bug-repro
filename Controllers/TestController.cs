using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CorsPolicyProblem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("A")]
        public string GetRoot() => "Hello World!";

        [HttpGet("A/B")]
        public string GetInner() => "Hello Inner World!";
    }
}