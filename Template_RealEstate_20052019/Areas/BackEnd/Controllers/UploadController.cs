using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.BackEnd.Base;

namespace Template_RealEstate_20052019.Areas.BackEnd.Controllers
{
    [Area("Backend")]
    public class UploadController : BaseController
    {
        [HttpPost]
        public async Task<JsonResult> Upload(IFormFile upload)
        {
            if (upload == null)
            {
                return null;
            }

            var fileName = await UploadFile(upload);

            return new JsonResult(new
            {
                path = "/upload/" + fileName
            });
        }
    }
}
