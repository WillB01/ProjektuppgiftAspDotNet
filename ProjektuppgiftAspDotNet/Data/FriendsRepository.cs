using ProjektuppgiftAspDotNet.Interface;
using ProjektuppgiftAspDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.Data
{
    public class FriendsRepository : IFriends
    {
        public List<AppUser> GetFriends => new List<AppUser>()
        {
            
        };
    }
}
