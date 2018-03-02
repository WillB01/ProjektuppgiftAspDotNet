using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjektuppgiftAspDotNet.Interface;
using ProjektuppgiftAspDotNet.Models;
using ProjektuppgiftAspDotNet.Models.ViewModel;

namespace ProjektuppgiftAspDotNet.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserIdentityRepository _userIdentityRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(IUserRepository userRepository,
            IUserIdentityRepository userIdentityRepository,
                IHttpContextAccessor httpContextAccessor)
        {
            _userRepository = userRepository;
            _userIdentityRepository = userIdentityRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                _userRepository.AddUser(user);

                return RedirectToAction("AllComments");
            }
            return View(user);
        }


        [HttpGet]
       
        public IActionResult AllComments()
        {
            return View(new CommentListViewModel
            {
                GetUser = _userRepository.GetUser
                .OrderByDescending(p => p.Id).ToList()
            });
        }

        [HttpGet]
        public IActionResult Edit(int? id,string IdentityId)
        {
            var userId = _httpContextAccessor.HttpContext
             .User.FindFirst(ClaimTypes.NameIdentifier);
            var loggedInUser = _userIdentityRepository
              .GetAppUser.FirstOrDefault(x =>
                  x.Id == userId.Value);

            if (id == null || loggedInUser.Id != IdentityId)
            {
                return NotFound();
            }

           

            //_userRepository.GetUser.FirstOrDefault(x => x.IdentityId)
            
            

            return View(_userRepository.GetUserById((int)id));
        }

        [HttpPost]
        public IActionResult Edit(int id, User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            _userRepository.Update(id, user);
                   
            return RedirectToAction("AllComments");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            return View(_userRepository.GetUserById((int)id));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {   
            _userRepository.Delete(id);
            return RedirectToAction("AllComments");
        }

        [HttpGet]
        public IActionResult Like(int id, User user)
        {
            _userRepository.Like(id, user);
           
            return RedirectToAction("AllComments");
        }
       
    }
}