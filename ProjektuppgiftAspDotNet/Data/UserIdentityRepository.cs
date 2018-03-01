using ProjektuppgiftAspDotNet.Interface;
using ProjektuppgiftAspDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.Data
{
    public class UserIdentityRepository : IUserIdentityRepository
    {
        private AppIdentityDbContext _appIdentityDbContext;

        public IQueryable<AppUser> GetAppUser => _appIdentityDbContext.Users;

        public UserIdentityRepository(AppIdentityDbContext appIdentityDbContext)
        {
            _appIdentityDbContext = appIdentityDbContext;
        }
    }
}
