using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public int Like { get; set; } = 0;
        public DateTime Posted { get; set; } = DateTime.Now;


    }
}
