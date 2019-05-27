using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class DesignViewComponent : ViewComponent
    {
        private readonly IConfiguration _configuration;

        public DesignViewComponent(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<DesignDetail> details = _configuration.GetSection("Design").Get<List<DesignDetail>>();

            return View(details);
        }
    }
}
