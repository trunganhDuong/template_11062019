using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Repositories;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class PolicyViewComponent : ViewComponent
    {
        private readonly IArticleRepository _articleRepository;

        public PolicyViewComponent(IArticleRepository articleRepository)
        {
            this._articleRepository = articleRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var policies = _articleRepository.GetList(new Template_RealEstate_20052019.Models.SearchRequest
            {
                PageIndex = 1,
                PageSize = 10,
                IsPolicy = true
            });

            return View(policies);
        }
    }
}
