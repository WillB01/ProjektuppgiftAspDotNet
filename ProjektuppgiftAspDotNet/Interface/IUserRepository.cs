using Microsoft.EntityFrameworkCore;
using ProjektuppgiftAspDotNet.Data;
using ProjektuppgiftAspDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.Interface
{
    public interface IUserRepository
    {
        IQueryable<User> GetUser { get; }
       
        User GetUserById(int id);

        void AddUser(User user);
        void Delete(int id);
        void Update(int id, User user);
        int Like(int id, User user);
        
       
    }
}
