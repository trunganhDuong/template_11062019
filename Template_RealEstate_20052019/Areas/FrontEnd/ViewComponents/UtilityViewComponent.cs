using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class UtilityViewComponent : ViewComponent
    {
        private readonly IConfiguration _configuration;

        public UtilityViewComponent(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Utility> utilities = _configuration.GetSection("Utilities").Get<List<Utility>>();

            return View(utilities);
        }
    }
}
