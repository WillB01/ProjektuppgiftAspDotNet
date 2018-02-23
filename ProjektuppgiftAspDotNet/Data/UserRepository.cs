using ProjektuppgiftAspDotNet.Interface;
using ProjektuppgiftAspDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public IQueryable<User> GetUser => _applicationDbContext.Users;

        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void AddUser(User user)
        {
            _applicationDbContext.Users.Add(user);
           
            

        }

        public void Update(User user)
        {
            _applicationDbContext.Update(user);
        }

        public void Save(User user)
        {
           
            _applicationDbContext.SaveChanges();
            
        }

        public User GetUserById(int id)
        {
            return _applicationDbContext.Users.FirstOrDefault(u => u.Id == id);
        }
    }
}
