using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Areas.FrontEnd.Controllers
{
    public class BaseController : Controller
    {
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
            ViewBag.Title = title;
        }
    }
}
