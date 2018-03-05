using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.ViewComponents
{
    public class SearchViewComponent : ViewComponent
    {
        [HttpGet]
        public IViewComponentResult Invoke()
        {



           
            return View("Default");
        }
    }
}
