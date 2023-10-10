using CodingChallengesApp.BL;
using CodingChallengesApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingChallengesApp.Controllers
{
    [Route("api/CodingChallenges")]
    [ApiController]
    public class CodingChallengeController(ILogger<CodingChallengeController> logger, ICodingChallengeBL codingChallenge) : Controller 
    {
        private readonly ILogger<CodingChallengeController> _logger = logger;
        private readonly ICodingChallengeBL _codingChallenge = codingChallenge;
       
        [HttpGet("all")]
        public async Task<IActionResult> GetChallenges()
        {
            var result = await _codingChallenge.GetAll();
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetChallenge(int id)
        {
            var result = _codingChallenge.GetSingle(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddCodingChallenge([FromBody] CodingChallenge codingChallenge)
        {
            _codingChallenge.Add(codingChallenge);
            return Ok();
        }
    }
}
