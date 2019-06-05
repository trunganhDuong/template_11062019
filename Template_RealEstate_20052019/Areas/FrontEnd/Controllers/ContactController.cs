using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Models;
using Template_RealEstate_20052019.Repositories;

namespace Template_RealEstate_20052019.Areas.FrontEnd.Controllers
{
    [Area("FrontEnd")]
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            this._contactRepository = contactRepository;
        }

        public async Task<string> Send(Contact contact)
        {
            if (contact == null)
            {
                return "Có lỗi xảy ra. Vui lòng thử lại";
            }
            if (!ModelState.IsValid)
            {
                return "Thông tin sai định dạng";
            }

            if (_contactRepository.Save(contact))
            {
                return "OK";
            }

            return "Có lỗi xảy ra. Vui lòng thử lại";
        }
    }
}
