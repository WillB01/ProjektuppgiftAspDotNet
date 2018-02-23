using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.Models.ViewModel
{
    public class CommentListViewModel
    {
        public IEnumerable<User> GetUser { get; set; }
    }
}
