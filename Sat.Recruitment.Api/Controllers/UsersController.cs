using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sat.Recruitment.Api.DTOs;
using Sat.Recruitment.Api.Exceptions;
using Sat.Recruitment.Api.Services;
using Sat.Recruitment.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public partial class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        // private readonly List<User> _users = new List<User>();
        public UsersController(IUserService us)
        {
            userService = us;
        }

        [HttpPost("create-user")]
        public IActionResult CreateUser([FromBody] UserDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new UserResponse()
                {
                    IsSuccess = false,
                    Errors = ModelState.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray())
                });
            }

            try
            {
                userService.CreateUser(model);
            }
            catch(Exception ex)
            {
                return BadRequest(new UserResponse()
                {
                    IsSuccess = false,
                    Message = ex.Message
                }) ;
            }

            return Created("", new UserResponse()
            {
                IsSuccess = true,
                Message = "User Created"
            });
        }
    }
}
