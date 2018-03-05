using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjektuppgiftAspDotNet.Interface;
using ProjektuppgiftAspDotNet.Models;

namespace ProjektuppgiftAspDotNet.Controllers
{
    public class ProfileController : Controller
    {
        private IUserIdentityRepository _userIdentityRepository;

        public ProfileController(IUserIdentityRepository userIdentityRepository)
        {
            _userIdentityRepository = userIdentityRepository;
        }

        [HttpPost]
        public IActionResult Index(string Prefix)
        {
            
            var user = (from c in _userIdentityRepository.GetAppUser
                             where c.UserName.StartsWith(Prefix)
                             select new  { value = c.UserName });

           
            
            return View(_userIdentityRepository
                .GetAppUser.FirstOrDefault(x => x.UserName == Prefix));
        }
    }
}