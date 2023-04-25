using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EGD_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListenerController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string message)
        {
            // Process the request and return a response
            return Ok($"Received message: {message}");
        }
    }
}