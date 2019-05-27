using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly IConfiguration _configuration;

        public SliderViewComponent(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var slides = _configuration.GetSection("Slider").Get<List<Slide>>();

            return View(slides);
        }
    }
}
