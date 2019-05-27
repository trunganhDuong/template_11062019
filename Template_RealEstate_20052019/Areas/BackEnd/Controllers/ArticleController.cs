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

        public async Task<IActionResult> Edit()
        {
            if (ItemId > 0)
            {
                var article = _articleRepository.GetById(ItemId);
                SetPageTitle("Chỉnh sửa bài viết");

                return View(article);
            }

            SetPageTitle("Thêm bài viết");

            return View(new Article());
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Article article)
        {
            if (!ModelState.IsValid)
            {
                return View(article);
            }

            SetFlashMessage("Success");

            return RedirectToAction("Edit");
        }
    }
}
