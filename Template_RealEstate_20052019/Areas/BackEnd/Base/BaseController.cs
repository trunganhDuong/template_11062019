using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Models;

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

        public User UserInfo { get; set; }

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

        protected async void UploadFile(List<IFormFile> files)
        {
            if (files == null || !files.Any())
            {
                return;
            }

            foreach (var file in files)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), Constants.UploadFilePath, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
        }

        protected async Task<string> UploadFile(IFormFile file)
        {
            if (file == null)
            {
                return string.Empty;
            }

            var fileName = DateTime.UtcNow.ToString("ddMMyyyyHHmmss") + file.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(), Constants.UploadFilePath, fileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return fileName;
        }

        protected async void SetAccountSession(User user)
        {
            await HttpContext.Session.LoadAsync();
            HttpContext.Session.SetString(Constants.AccountSessionKey, JsonConvert.SerializeObject(user));
            await HttpContext.Session.CommitAsync();
        }

        protected async void RemoveAccountSession()
        {
            await HttpContext.Session.LoadAsync();
            HttpContext.Session.Remove(Constants.AccountSessionKey);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            HandleAuthendication();
            var controllerActionDescriptor = filterContext.ActionDescriptor as ControllerActionDescriptor;
            var listAtributes = controllerActionDescriptor.MethodInfo.GetCustomAttributesData();
            var isAnonymousAllowed = listAtributes.FirstOrDefault(c => c.AttributeType == typeof(AllowAnonymousAttribute)) != null;
            if (UserInfo == null && !isAnonymousAllowed)
            {
                filterContext.Result = new RedirectResult(Url.Action("Index", "Login", new { Area = "Backend" }));
                return;
            }
        }

        private async void HandleAuthendication()
        {
            await HttpContext.Session.LoadAsync();
            var sessionData = HttpContext.Session.GetString(Constants.AccountSessionKey)?.ToString();
            if (string.IsNullOrEmpty(sessionData))
            {
                UserInfo = null;

                return;
            }
            UserInfo = JsonConvert.DeserializeObject<User>(sessionData);
            ViewBag.Username = UserInfo.Username;
        }
    }
}
