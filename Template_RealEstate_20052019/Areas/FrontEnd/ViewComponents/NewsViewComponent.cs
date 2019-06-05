using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Models;
using Template_RealEstate_20052019.Repositories;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class NewsViewComponent:ViewComponent
    {
        private readonly IArticleRepository _articleRepository;

        public NewsViewComponent(IArticleRepository articleRepository)
        {
            this._articleRepository = articleRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var articles = _articleRepository.GetList(new SearchRequest
            {
                PageIndex = 1,
                PageSize = 3
            });

            return View(articles?.Data);
        }
    }
}
