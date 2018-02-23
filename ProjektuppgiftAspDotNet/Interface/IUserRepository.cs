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
        void AddUser(User user);
        User GetUserById(int id);

        void Save(User user);
        void Update(User user);
    }
}
