using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.BackEnd.Base;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;
using Template_RealEstate_20052019.Models;
using Template_RealEstate_20052019.Repositories;

namespace Template_RealEstate_20052019.Areas.BackEnd.Controllers
{
    [Area("Backend")]
    public class UtilityController : BaseController
    {
        private readonly IUtilityRepository _utilityRepository;

        public UtilityController(IUtilityRepository utilityRepository)
        {
            this._utilityRepository = utilityRepository;
        }

        public async Task<IActionResult> Index()
        {
            var request = new SearchRequest
            {
                PageIndex = PageIndex,
                PageSize = Constants.ListPageSize,
                IsPolicy = false
            };
            var utilities = _utilityRepository.GetList(request);
            SetPageTitle("Quản lý tiện ích");

            return View(utilities);
        }

        public async Task<IActionResult> Edit()
        {
            if (ItemId > 0)
            {
                var article = _utilityRepository.GetById(ItemId);
                SetPageTitle("Chỉnh sửa tiện ích");

                return View(article);
            }

            SetPageTitle("Thêm tiện tích");

            return View(new Utility());
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Utility utility)
        {
            if (!ModelState.IsValid)
            {
                return View(utility);
            }

            if (_utilityRepository.Save(utility))
                SetFlashMessage("Thêm tiện tích thành công");
            else
                SetFlashMessage("Tiện ích đã tồn tại. Bạn cần chọn loại tiện ích khác", false);

            return RedirectToAction("Edit", new { itemId = utility.UtilityId });
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
                _utilityRepository.Delete(ItemId);
                SetFlashMessage("Xóa tiện ích thành công");
            }

            return RedirectToAction("Index");
        }
    }
}
