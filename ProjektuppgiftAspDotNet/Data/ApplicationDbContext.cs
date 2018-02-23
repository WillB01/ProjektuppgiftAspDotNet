using Microsoft.EntityFrameworkCore;
using ProjektuppgiftAspDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {   
        }

        public DbSet<User> Users { get; set; }
    }
}
