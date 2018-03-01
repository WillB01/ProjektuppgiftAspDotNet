using Microsoft.AspNetCore.Mvc;
using ProjektuppgiftAspDotNet.Interface;
using ProjektuppgiftAspDotNet.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.ViewComponents
{
    public class UserViewComponent : ViewComponent
    {
        private IUserRepository _userRepository;

        public UserViewComponent(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IViewComponentResult Invoke()
        {

            var model = _userRepository.GetUser.OrderByDescending(u => u.Id);
            return View("Default", model);
        }

      
    }
}
