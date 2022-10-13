using Microsoft.AspNetCore.Mvc;
using vHackTolkienAPI.Models;
using vHackTolkienAPI.Services;

namespace vHackTolkienAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        private readonly ITestService _testService;
        public TestController(ITestService testService)
        {
            _testService = testService;
        }
        [HttpPost]
        public async Task<IActionResult> AddTest([FromBody] Test test)
        {
            var result = await _testService.CreateTest(test);

            return Ok(result);
        }
    }
}
