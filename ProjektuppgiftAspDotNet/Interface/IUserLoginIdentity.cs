using Microsoft.AspNetCore.Identity;
using ProjektuppgiftAspDotNet.Models;
using ProjektuppgiftAspDotNet.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.Interface
{
    public interface IUserLoginIdentity
    {
        UserManager<AppUser> LoggedInUser { get; }
    }
}
