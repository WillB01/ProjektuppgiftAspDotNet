using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjektuppgiftAspDotNet.Interface;

namespace ProjektuppgiftAspDotNet.Controllers
{
    public class FriendsController : Controller
    {
        private IUserIdentityRepository _userIdentityRepository;

        public FriendsController(IUserIdentityRepository userIdentityRepository)
        {
            _userIdentityRepository = userIdentityRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(bool add)
        {
            if (add)
            {
                var model = _userIdentityRepository
              .GetAppUser.FirstOrDefault(u => u.UserName == "Lisa");
                return View(model);
            }
            return View();
        }
    }
}