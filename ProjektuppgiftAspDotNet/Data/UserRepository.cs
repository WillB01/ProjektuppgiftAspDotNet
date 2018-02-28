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
            _applicationDbContext.SaveChanges();          

        }

        public User GetUserById(int id)
        {
            return _applicationDbContext.Users.FirstOrDefault(u => u.Id == id);
        }

        public void Update(int id, User user)
        {
            var u = _applicationDbContext.Users.Find(id);
            if(u != null)
            {
                user.Name = u.Name;
                u.Message = user.Message;
                u.Posted = user.Posted;
                _applicationDbContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var user = _applicationDbContext
                .Users
                .FirstOrDefault(u => u.Id == id);
            if(user != null)
            {
                _applicationDbContext.Remove(user);
                _applicationDbContext.SaveChanges();
            }
        }

        public int Like(int id, User user)
        {
            var _user = _applicationDbContext
                .Users
                .FirstOrDefault(u => u.Id == id);
            if(user != null)
            {
                _user.Like += ++user.Like;
                _applicationDbContext.SaveChanges();
            }
            return user.Like;
        }
       
    }
}
