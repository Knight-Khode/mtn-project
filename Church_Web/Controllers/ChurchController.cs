using AutoMapper;
using Church_Web.Configurations;
using Church_Web.Db_Model;
using Church_Web.Interfaces.Repositories;
using Church_Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Church_Web.Controllers
{
    public class ChurchController : Controller
    {
        private readonly Logger _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitofwork;
        private readonly UserManager<User> _userManager;

        public ChurchController(Logger logger, IUnitOfWork unitOfWork,
            IMapper mapper, UserManager<User> userManager)
        {
            _logger = logger;
            _unitofwork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;

        }

        [HttpGet]
        public async Task<IActionResult> Churches()
        {
            try
            {
                //Get all upcoming events
                var mainpageInfo = new ChurchMainPageViewModel
                {
                    Events = await _unitofwork.UpcomingEvent.GetAll(),
                    Churches = await _unitofwork.Churchlist.GetAll()
                };
                var eventResult = _mapper.Map<IList<ChurchMainPageViewModel>>(mainpageInfo.Events);
                var churchResult = _mapper.Map<IList<ChurchMainPageViewModel>>(mainpageInfo.Churches);

                return View(mainpageInfo);
            }
            catch (Exception ex)
            {
                _logger.logError($"{ex} an error occurred");
            }
            return View();
        }
    }

}
