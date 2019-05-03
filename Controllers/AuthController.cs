using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Quiz.API.Data;
using Quiz.API.Dtos;
using Quiz.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Quiz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IDataRepository _repo;
        private readonly IConfiguration _config;

        public AuthController(IDataRepository repo, IConfiguration config)
        {
            _config = config;
            this._repo = repo;
        }
        
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForloginDto)
        {
            // try
            // {
            //     throw new Exception("Computer says no!");
                
            //     var userFromRepo = await _repo.Login(userForloginDto.Username.ToLower(), userForloginDto.Password);
            //     if(userFromRepo == null)
            //         Unauthorized();

            //     var claims = new[]
            //     {
            //         new Claim(ClaimTypes.NameIdentifier, userFromRepo.Id.ToString()),
            //         new Claim(ClaimTypes.Name, userFromRepo.UserName)
            //     };

            //     var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));
            //     var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            //     var tokenDescriptor = new SecurityTokenDescriptor
            //     {
            //         Subject = new ClaimsIdentity(claims),
            //         Expires = DateTime.Now.AddDays(1),
            //         SigningCredentials = creds
            //     };

            //     var tokenHandler = new JwtSecurityTokenHandler();
            //     var token = tokenHandler.CreateToken(tokenDescriptor);
                
            //     return Ok(new {
            //         token = tokenHandler.WriteToken(token)
            //     });  
            // }
            // catch (System.Exception)
            // {
            //       throw new Exception("Computer says no no!");
            // }
            return Ok();
        }
    }
}