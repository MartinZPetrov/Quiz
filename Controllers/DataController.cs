using System.Threading.Tasks;
using Quiz.API.Data;
using Quiz.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System;
using Quiz.API.Models;

namespace Quiz.API.Controllers
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
            List<Settings> settings;
            try
            {
                settings  = await _repo.GetSettings();
            }
            catch (System.Exception)
            {
                throw new Exception("Error Loading Settings!");
            }
            
            return Ok(settings);
        }

        [AllowAnonymous]
        [HttpGet("questions")]
        public async Task<IActionResult> Questions()
        {
            List<Questions> questions;
            try
            {
                questions  = await _repo.GetQuestions();
            }
            catch (System.Exception)
            {
                 throw new Exception("Error Loading Questions!");
            }
            
            return Ok(questions);
        }
        
        [AllowAnonymous]
        [HttpGet("multiplequestions")]
        public async Task<IActionResult> MultipleQuestionsAndAnswers()
        {
            List<MultipleQuestions> multipleQuestions;
            try
            {
                multipleQuestions  = await _repo.GetMultipleQuestions(); 
            }
            catch (System.Exception)
            {
                throw new Exception("Error loading questions and multiple answers!");
            }
            return Ok(multipleQuestions);
        }
    }
}