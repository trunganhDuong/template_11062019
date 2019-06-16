using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.BackEnd.Base;
using Template_RealEstate_20052019.Models;
using Template_RealEstate_20052019.Repositories;
using Template_RealEstate_20052019.Utils;

namespace Template_RealEstate_20052019.Areas.BackEnd.Controllers
{
    [Area("Backend")]
    public class UpdatePasswordController : BaseController
    {
        private readonly IUserRepository _userRepository;

        public UpdatePasswordController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public async Task<IActionResult> Index()
        {
            SetPageTitle("Đổi mật khẩu");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string current, string newPassword, string confirm)
        {
            SetPageTitle("Đổi mật khẩu");

            if (string.IsNullOrEmpty(current) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirm))
            {
                SetFlashMessage("Bạn cần nhập đủ thông tin", false);
                return View();
            }

            if (newPassword != confirm)
            {
                SetFlashMessage("Confirm mật khẩu không chính xác", false);
                return View();
            }

            if (!_userRepository.UpdatePassword(new User
            {
                UserId = UserInfo.UserId,
                Password = current,
                Username = UserInfo.Username
            }, newPassword))
            {
                SetFlashMessage("Mật khẩu hiện tại không chính xác", false);
                return View();
            }

            RemoveAccountSession();
            SetFlashMessage("Đổi mật khẩu thành công");

            return Redirect(Url.Action("Index", "Login", new { Area = "Backend" }));
        }
    }
}
