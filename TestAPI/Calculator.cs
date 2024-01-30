using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class Calculator : ControllerBase
    {
        [HttpGet("add")]
        public IActionResult Add(decimal num1, decimal num2)
        {
            decimal result = num1 + num2;
            return Ok(new { result });
        }
            [HttpGet("subtract")]
        public IActionResult Subtract(decimal num1, decimal num2)
        {
            decimal result = num1 - num2;
            return Ok(new { result });
        }

    }
}
