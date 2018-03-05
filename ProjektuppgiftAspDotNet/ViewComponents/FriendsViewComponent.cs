using Microsoft.AspNetCore.Mvc;
using ProjektuppgiftAspDotNet.Interface;
using ProjektuppgiftAspDotNet.Models;
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

        public IViewComponentResult Invoke(bool add, string name)
        {
            if (add)
            {
                var model = _userIdentityRepository
              .GetAppUser.FirstOrDefault(u => u.UserName == name);
                return View("Default", model);
            }
            return View("Default");
          
        } 

     
        private IQueryable<AppUser> AppUser(string id)
        {
            return _userIdentityRepository.GetAppUser.Where(x => x.UserName == id).AsQueryable();
        }

        
    }
}
