using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Api.Interfaces.User;
using ProjectManagement.Api.Models;
using ProjectManagement.Api.Services.User;

namespace ProjectManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices = new UserServices();
        
        [HttpGet("all-users")]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _userServices.GetAllUsers();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var result = await _userServices.GetUserById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("create-user")]
        public async Task<IActionResult> CreateUser([FromBody] UserModel user)
        {
            var newUser = await _userServices.CreateUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = newUser.Id }, newUser);
        }
    }
}