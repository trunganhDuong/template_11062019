using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Areas.FrontEnd.Controllers
{
    [Area("FrontEnd")]
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = _configuration.GetSection("PageTitle").Get<string>();

            return View();
        }
    }
}
