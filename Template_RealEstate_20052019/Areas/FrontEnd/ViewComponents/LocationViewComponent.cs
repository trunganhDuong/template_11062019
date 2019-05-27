using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class LocationViewComponent : ViewComponent
    {
        private readonly IOptions<Location> _option;

        public LocationViewComponent(IOptions<Location> option)
        {
            this._option = option;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_option.Value);
        }
    }
}
