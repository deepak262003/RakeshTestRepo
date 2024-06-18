using System.Text.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace WasmBlazor.Controllers
{
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public SampleController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        [Route("/gettext")]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello from the server!" });
        }
    }
}
