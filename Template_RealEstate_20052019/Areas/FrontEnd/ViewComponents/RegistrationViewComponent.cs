using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Models;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class RegistrationViewComponent : ViewComponent
    {
        private readonly IOptions<ContactInformation> _options;

        public RegistrationViewComponent(IOptions<ContactInformation> options)
        {
            this._options = options;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var contactInfo = _options.Value;

            return View(contactInfo);
        }
    }
}
