using Microsoft.AspNetCore.Http;
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
    public class PolicyController : BaseController
    {
        private readonly IArticleRepository _articleRepository;

        public PolicyController(IArticleRepository articleRepository)
        {
            this._articleRepository = articleRepository;
        }

        public async Task<IActionResult> Index()
        {
            var request = new SearchRequest
            {
                PageIndex = PageIndex,
                PageSize = Constants.ListPageSize,
                IsPolicy = true
            };
            var articles = _articleRepository.GetList(request);
            SetPageTitle("Quản lý chính sách");

            return View(articles);
        }

        public async Task<IActionResult> Edit()
        {
            if (ItemId > 0)
            {
                var article = _articleRepository.GetById(ItemId);
                SetPageTitle("Chỉnh sửa chính sách");

                return View(article);
            }

            SetPageTitle("Thêm chính sách");

            return View(new Article());
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Article article, IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                return View(article);
            }

            if (file != null)
            {
                article.Avatar = file.FileName;
                UploadFile(new List<IFormFile> { file });
            }

            article.IsPolicy = true;
            _articleRepository.Save(article);
            SetFlashMessage("Thêm chính sách thành công");

            return RedirectToAction("Edit", new { itemId = article.ArticleId });
        }

        [HttpGet]
        public async Task<IActionResult> Delete()
        {
            if (ItemId <= 0)
            {
                SetFlashMessage("Có lỗi xảy ra", false);
                return RedirectToAction("Index");
            }
            else
            {
                _articleRepository.Delete(ItemId);
                SetFlashMessage("Xóa tin thành công");
            }

            return RedirectToAction("Index");
        }
    }
}
