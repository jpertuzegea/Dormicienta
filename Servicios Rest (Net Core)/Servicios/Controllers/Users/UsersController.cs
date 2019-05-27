using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Servicios.Entities;
using BLL_Net.Entidades;
using Servicios.Services;
using Microsoft.Extensions.Configuration;

namespace Servicios.Controllers.Users
{
    [Authorize]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] BLL_Net.Entidades.Users userParam)
        {
            var user = _userService.Authenticate(userParam.Username, userParam.Password );

            if (user == null)
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }
            else
            {
                return Ok(user);
            }
        }

        [Authorize(Roles = Role.Admin)]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            // only allow admins to access other user records
            var currentUserId = int.Parse(User.Identity.Name);
            if (id != currentUserId && !User.IsInRole(Role.Admin))
            {
                return Forbid();
            }
            else
            {
                return Ok(user);
            }
        }



        [AllowAnonymous]
        [HttpGet("refreshToken/{refreshToken}")]
        public IActionResult RefreshToken(string refreshToken)
        {
            var user = _userService.RefreshToken(refreshToken);

            if (user == null)
            {
                return BadRequest(new { message = "Autentications is incorrect" });
            }
            else
            {
                return Ok(user);
            }


        }

    }
}
