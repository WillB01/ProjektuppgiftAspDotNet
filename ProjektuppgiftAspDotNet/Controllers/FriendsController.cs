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
        private IFriends _friends;

        public FriendsController(IUserIdentityRepository userIdentityRepository, 
            IFriends friends)
        {
            _userIdentityRepository = userIdentityRepository;
            _friends = friends;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(bool add, string name)
        {
            
           
            if (add)
            {
                var model = _userIdentityRepository
              .GetAppUser.FirstOrDefault(u => u.UserName == name);

                
                return View(model);
            }
            return View();
        }
    }
}