using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Models;
using Template_RealEstate_20052019.Repositories;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class RecentPostViewComponent : ViewComponent
    {
        private readonly IArticleRepository _articleRepository;

        public RecentPostViewComponent(IArticleRepository articleRepository)
        {
            this._articleRepository = articleRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(bool isPolicy = false)
        {
            var articles = _articleRepository.GetList(new SearchRequest
            {
                PageIndex = 1,
                PageSize = 5,
                IsPolicy = isPolicy
            });

            return View(articles);
        }
    }
}
