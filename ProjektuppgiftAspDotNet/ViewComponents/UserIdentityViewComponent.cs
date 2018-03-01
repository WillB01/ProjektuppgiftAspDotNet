using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjektuppgiftAspDotNet.Interface;
using ProjektuppgiftAspDotNet.Models;
using ProjektuppgiftAspDotNet.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.ViewComponents
{
    public class UserIdentityViewComponent : ViewComponent
    {
        private IUserIdentityRepository _userIdentityRepository;
        private IUserLoginIdentity _userLoginIdentity;

        private IHttpContextAccessor _httpContextAccessor;
        

        public UserIdentityViewComponent(IUserIdentityRepository userIdentityRepository, 
            IUserLoginIdentity userLoginIdentity,
                IHttpContextAccessor httpContextAccessor)
        {
            _userIdentityRepository = userIdentityRepository;
            _userLoginIdentity = userLoginIdentity;
            _httpContextAccessor = httpContextAccessor;
 
        }

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            

            var userId = _httpContextAccessor.HttpContext
                .User.FindFirst(ClaimTypes.NameIdentifier);

            
            
            return View("Default", _userIdentityRepository
                .GetAppUser.FirstOrDefault(x =>
                    x.Id == userId.Value));
        }


    }
}
