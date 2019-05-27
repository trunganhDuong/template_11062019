using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class OverviewViewComponent : ViewComponent
    {
        private readonly IOptions<ProjectInformation> _options;

        public OverviewViewComponent(IOptions<ProjectInformation> options)
        {
            this._options = options;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_options.Value);
        }
    }
}
