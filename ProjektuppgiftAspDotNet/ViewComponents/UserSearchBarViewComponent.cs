using Microsoft.AspNetCore.Mvc;
using ProjektuppgiftAspDotNet.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.ViewComponents
{
    public class UserSearchBarViewComponent : ViewComponent
    {
        private IUserIdentityRepository _userIdentityRepository;

        public UserSearchBarViewComponent(IUserIdentityRepository userIdentityRepository)
        {
            _userIdentityRepository = userIdentityRepository;
        }

        [HttpPost]
        public IViewComponentResult Invoke(string Prefix)
        {
            var Countries = (from c in _userIdentityRepository.GetAppUser
                             where c.UserName.StartsWith(Prefix)
                             select new { value = c.UserName });


            return View("Default", Countries);
        }



    }
}

