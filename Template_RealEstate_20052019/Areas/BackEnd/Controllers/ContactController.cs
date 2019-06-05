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
    public class ContactController : BaseController
    {
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            this._contactRepository = contactRepository;
        }

        public async Task<IActionResult> Index()
        {
            var request = new SearchRequest
            {
                PageIndex = PageIndex,
                PageSize = Constants.ListPageSize
            };
            var contacts = _contactRepository.GetList(request);
            SetPageTitle("Quản lý liên hệ");

            return View(contacts);
        }

        [HttpGet]
        public async Task<JsonResult> Export()
        {
            var request = new SearchRequest
            {
                PageIndex = PageIndex,
                PageSize = 1000000
            };
            var contacts = _contactRepository.GetList(request);

            return Json(contacts.Data);
        }
    }
}
