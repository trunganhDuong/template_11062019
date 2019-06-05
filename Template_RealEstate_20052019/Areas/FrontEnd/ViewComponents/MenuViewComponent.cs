using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IConfiguration _configuration;

        public MenuViewComponent(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public async Task<IViewComponentResult> InvokeAsync(bool isNews = false)
        {
            List<Menu> menu = _configuration.GetSection("Menu").Get<List<Menu>>();
            if (isNews)
            {
                foreach(var item in menu)
                {
                    item.Href = "/" + item.Href;
                }
            }

            return View(menu);
        }
    }
}
