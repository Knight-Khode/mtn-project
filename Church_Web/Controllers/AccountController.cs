using AutoMapper;
using Church_Web.Configurations;
using Church_Web.Db_Model;
using Church_Web.Interfaces.Repositories;
using Church_Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Church_Web.Models.UserViewModel;

namespace Church_Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly Logger _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitofwork;
        private readonly UserManager<User> _userManager;
        private readonly IUserClaimsPrincipalFactory<User> _userClaims;

        public AccountController(Logger logger, IMapper mapper,
            IUnitOfWork unitofwork, UserManager<User> userManager, IUserClaimsPrincipalFactory<User> userClaims)
        {
            _logger = logger;
            _mapper = mapper;
            _unitofwork = unitofwork;
            _userManager = userManager;
            _userClaims = userClaims;

        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
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

                        //return RedirectToAction("Index");
                        if (!string.IsNullOrEmpty(returnUrl))
                        {
                            return LocalRedirect(returnUrl);
                        }
                        else
                        {
                            return View(principal);
                        }
                    }
                    ModelState.AddModelError(string.Empty, "Invalid Username or Password");

                    return View();
                }
            }
            catch (Exception ex)
            {
                _logger.logError($"{ex} failed to login user");
            }
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Signup([FromForm] RegisterUserDto userDto)
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
                            var assignRole = await _userManager.AddToRoleAsync(userInfo, "StandardUser");
                        }
                        else if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError(error.Code, error.Description);
                            }
                            return View(nameof(SignupFailed), "An Error Occurred");
                        }
                        return View(result);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.logError(ex);
            }
            return View(nameof(SignupFailed), "An Error Occurred");

        }
        public IActionResult SignupFailed()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword()
        {
            return View();
        }
    }
}
