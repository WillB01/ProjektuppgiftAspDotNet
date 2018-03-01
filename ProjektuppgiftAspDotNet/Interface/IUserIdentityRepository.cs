using ProjektuppgiftAspDotNet.Models;
using ProjektuppgiftAspDotNet.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.Interface
{
    public interface IUserIdentityRepository
    {
        IQueryable<AppUser> GetAppUser { get; }
        
       
    }
}
