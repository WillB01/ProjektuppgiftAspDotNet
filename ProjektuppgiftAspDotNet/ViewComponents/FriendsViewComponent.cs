using Microsoft.AspNetCore.Mvc;
using ProjektuppgiftAspDotNet.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.ViewComponents
{
    public class FriendsViewComponent : ViewComponent
    {
        private IUserIdentityRepository _userIdentityRepository;

        public FriendsViewComponent(IUserIdentityRepository userIdentityRepository)
        {
            _userIdentityRepository = userIdentityRepository;
        }

        public IViewComponentResult Invoke()
        {
            var model = _userIdentityRepository.GetAppUser;
            return View("Default",model);
        } 
    }
}
