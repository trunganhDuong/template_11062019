using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.BackEnd.Base;

namespace Template_RealEstate_20052019.Areas.BackEnd.Controllers
{
    [Area("Backend")]
    public class LogoutController : BaseController
    {
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            RemoveAccountSession();

            return Redirect(Url.Action("Index", "Login", new { Area = "Backend" }));
        }
    }
}
