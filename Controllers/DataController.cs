using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IDataRepository _repo;
        private readonly IConfiguration _config;       
        public DataController (IDataRepository repo, IConfiguration config)
        {
            _config = config;
            this._repo = repo;
        }

        [AllowAnonymous]
        [HttpGet("settings")]
        public async Task<IActionResult> Settings()
        {
            var settings  = await _repo.GetSettings();
            return Ok(settings);
        }

        [AllowAnonymous]
        [HttpGet("questions")]
        public async Task<IActionResult> Questions()
        {
            var questions  = await _repo.GetQuestions();
            return Ok(questions);
        }
        
        [AllowAnonymous]
        [HttpGet("multiplequestions")]
        public async Task<IActionResult> Answers()
        {
            var multipleQuestions  = await _repo.GetMultipleQuestions();
            return Ok(multipleQuestions);
        }
    }
}