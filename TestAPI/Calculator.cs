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
        [HttpGet("multiply")]
        public IActionResult Multiply(decimal num1, decimal num2)
        {
            decimal result = num1 * num2;
            return Ok(new { result });
        }

        [HttpGet("divide")]
        public IActionResult Divide(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Cannot divide by zero");
            }
            decimal result = num1 / num2;
            return Ok(new { result });
        }
        [HttpGet("modulo")]
        public IActionResult Modulo(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Cannot calculate modulo by zero");
            }
            decimal result = num1 % num2;
            return Ok(new { result });
        }
    }
}
