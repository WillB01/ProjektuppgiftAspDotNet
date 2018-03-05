using Microsoft.AspNetCore.Mvc;
using ProjektuppgiftAspDotNet.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.ViewComponents
{
    public class SearchViewComponent : ViewComponent
    {
        private IUserIdentityRepository _userIdentityRepository;

        public SearchViewComponent(IUserIdentityRepository userIdentityRepository)
        {
            _userIdentityRepository = userIdentityRepository;
        }

        [HttpGet]
        public IViewComponentResult Invoke()
        {



           
            return View("Default");
        }
    }
}
