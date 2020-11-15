using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.API.Models.Request;
using TaskManagement.Business.Abstract;
using TaskManagement.Entities;

namespace TaskManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public AccountController(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginModel)
        {
            var user = _accountService.Login(loginModel.Email, loginModel.Password);
            if (user != null)
            {
                return Ok(user);
            }
            return Unauthorized();
        }


        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerModel)
        {
            var user = await _accountService.FindByEmailAsync(registerModel.Email);
            if(user == null)
            {
                user = _mapper.Map<AppUser>(registerModel);
                await _accountService.Register(user);
                return Ok();
            }
            return BadRequest();
        }
    }
}
