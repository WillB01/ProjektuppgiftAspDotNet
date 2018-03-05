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

       
        public IViewComponentResult Invoke(string Prefix)
        {

            var user = (from c in _userIdentityRepository.GetAppUser
                        where c.UserName.StartsWith(Prefix)
                        select new { value = c.UserName });



            return View("Default",_userIdentityRepository
                .GetAppUser.FirstOrDefault(x => x.UserName == Prefix));


           
        }
    }
}
