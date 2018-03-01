using Microsoft.AspNetCore.Identity;
using ProjektuppgiftAspDotNet.Interface;
using ProjektuppgiftAspDotNet.Models;
using ProjektuppgiftAspDotNet.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.Data
{
    public class LoggedInRepository : IUserLoginIdentity
    {
        private UserManager<AppUser> _loginModel;

        public LoggedInRepository(UserManager<AppUser> loginModel)
        {
            _loginModel = loginModel;
        }



        public UserManager<AppUser> LoggedInUser => _loginModel;
    }
}
