using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tweet22.Server.Data;
using tweet22.Shared;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tweet22.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }


        // POST: /api/<controller>/register
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegister request)
        {
            var response = await _authRepository.Register(
                new Shared.User
                {
                    Username = request.Username,
                    Email = request.Email,
                    Bananas = request.Bananas,
                    DateOfBirth = request.DateOfBirth,
                    IsConfirmed = request.IsConfirmed
                }, request.Password);

            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

        // POST: /api/<controller>/login
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLogin request)
        {
            var response = await _authRepository.Login(
                request.Email, request.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}

