using Microsoft.AspNetCore.Authorization;
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
    public class LoginController : BaseController
    {
        private readonly IUserRepository _userRepository;

        public LoginController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(User user)
        {
            user = _userRepository.Validate(user);
            if (user == null)
            {
                SetFlashMessage("Thông tin đăng nhập không chính xác. Hãy thử lại", false);

                return View();
            }
            SetAccountSession(user);

            return Redirect(Url.Action("Index", "Utility", new { Area = "BackEnd" }));
        }

        
    }
}
