using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.BackEnd.Base;
using Template_RealEstate_20052019.Models;
using Template_RealEstate_20052019.Repositories;

namespace Template_RealEstate_20052019.Areas.BackEnd.Controllers
{
    [Area("Backend")]
    public class ArticleController : BaseController
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleController(IArticleRepository articleRepository)
        {
            this._articleRepository = articleRepository;
        }

        public async Task<IActionResult> Index()
        {
            var request = new SearchRequest
            {
                PageIndex = PageIndex,
                PageSize = Constants.ListPageSize
            };
            var articles = _articleRepository.GetList(request);
            SetPageTitle("Quản lý bài viết");

            return View(articles);
        }
    }
}
