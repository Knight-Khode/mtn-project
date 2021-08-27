using AutoMapper;
using Church_Web.Configurations;
using Church_Web.Db_Model;
using Church_Web.Interfaces.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Church_Web.Models.UserViewModel;

namespace Church_Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly Logger _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitofwork;
        private readonly UserManager<User> _userManager;
        private readonly IUserClaimsPrincipalFactory<User> _userClaims;
        private readonly RoleManager<IdentityRole> _roleManger;

        public UserController(Logger logger, IMapper mapper,
            IUnitOfWork unitofwork, UserManager<User> userManager, IUserClaimsPrincipalFactory<User> userClaims, RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _mapper = mapper;
            _unitofwork = unitofwork;
            _userManager = userManager;
            _userClaims = userClaims;
            _roleManger = roleManager;
        }
        [HttpPost("submit/register")]
        public async Task<IActionResult> Register([FromForm] RegisterUserDto userDto)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var user = await _userManager.FindByNameAsync(userDto.Username);
                    if (user == null)
                    {
                        user = _mapper.Map<User>(userDto);
                        var result = await _userManager.CreateAsync(user, userDto.Password);
                        if (result.Succeeded)
                        {
                            var userInfo = await _userManager.FindByNameAsync(userDto.Username);
                            if ( !await _roleManger.RoleExistsAsync("StandardUser"))
                            {
                                var role = new IdentityRole();
                                role.Name = "StandardUser";
                                await _roleManger.CreateAsync(role);
                            }
                            var assignRole = await _userManager.AddToRoleAsync(userInfo, "StandardUser");
                        }
                        else
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError(error.Code, error.Description);
                            }
                            return Ok(new {status ="Success",});

                        }
                        return Ok(result);
                    }
                }
            }

            catch (Exception ex)
            {
                _logger.logError(ex);
            }
            return BadRequest(new { status = "Failed", });

        }


        [HttpPost("submit/signin")]
        public async Task<IActionResult> Login([FromForm] LoginUserDto loginUser, string returnUrl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = await _userManager.FindByNameAsync(loginUser.Username);
                    if (user != null && await _userManager.CheckPasswordAsync(user, loginUser.Password))
                    {
                        var principal = await _userClaims.CreateAsync(user);
                        await HttpContext.SignInAsync("Identity.Application", principal);

                        if (!string.IsNullOrEmpty(returnUrl))
                        {
                            return LocalRedirect(returnUrl);
                        }
                        else
                        {
                            return Ok(new { status = "success" });
                        }
                    }
                    ModelState.AddModelError(string.Empty, "Invalid Username or Password");

                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                _logger.logError($"{ex} failed to load login data");
            }
            return BadRequest(new { status = "error" });
        }
    }
}
