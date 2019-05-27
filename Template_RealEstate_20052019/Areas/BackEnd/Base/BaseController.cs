using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Areas.BackEnd.Base
{
    public class BaseController : Controller
    {
        public int PageIndex
        {
            get
            {
                if (HttpContext.Request.Query == null || string.IsNullOrEmpty(HttpContext.Request.Query["p"]))
                {
                    return 1;
                }

                return int.Parse(HttpContext.Request.Query["p"]);
            }
        }

        public int ItemId
        {
            get
            {
                if (HttpContext.Request.Query == null || string.IsNullOrEmpty(HttpContext.Request.Query["itemId"]))
                {
                    return 0;
                }

                return int.Parse(HttpContext.Request.Query["itemId"]);
            }
        }

        protected void SetPageTitle(string title)
        {
            ViewBag.PageTitle = title;
        }

        protected void SetFlashMessage(string message, bool success = true)
        {
            if (success)
            {
                TempData["SuccessMessage"] = message;
            }
            else
            {
                TempData["ErrorMessage"] = message;
            }
        }
    }
}
