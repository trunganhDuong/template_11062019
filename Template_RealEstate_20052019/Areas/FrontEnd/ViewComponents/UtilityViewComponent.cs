using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;
using Template_RealEstate_20052019.Models;
using Template_RealEstate_20052019.Repositories;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class UtilityViewComponent : ViewComponent
    {
        private readonly IUtilityRepository _utilityRepository;

        public UtilityViewComponent(IUtilityRepository utilityRepository)
        {
            this._utilityRepository = utilityRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            GridModel<Utility> utilities = _utilityRepository.GetList(new Template_RealEstate_20052019.Models.SearchRequest
            {
                PageIndex = 1,
                PageSize = 20
            });

            return View(utilities);
        }
    }
}
