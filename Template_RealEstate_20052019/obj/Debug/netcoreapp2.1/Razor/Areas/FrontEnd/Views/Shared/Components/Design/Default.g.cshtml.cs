#pragma checksum "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96d8813e045ae02e09492edb0c9f2e2bfcd917ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_FrontEnd_Views_Shared_Components_Design_Default), @"mvc.1.0.view", @"/Areas/FrontEnd/Views/Shared/Components/Design/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/FrontEnd/Views/Shared/Components/Design/Default.cshtml", typeof(AspNetCore.Areas_FrontEnd_Views_Shared_Components_Design_Default))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96d8813e045ae02e09492edb0c9f2e2bfcd917ff", @"/Areas/FrontEnd/Views/Shared/Components/Design/Default.cshtml")]
    public class Areas_FrontEnd_Views_Shared_Components_Design_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DesignDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(86, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
 if (Model != null && Model.Any())
{

#line default
#line hidden
            BeginContext(127, 546, true);
            WriteLiteral(@"    <!-- Start portfolio Area -->
    <div id=""design"" class=""about-area portfolio-area area-padding fix section-padding"">
        <div class=""container"">
            <div class=""page-title text-center"">
                <h1>Thiết kế mặt bằng</h1>
                <p></p>
                <hr class=""pg-titl-bdr-btm""></hr>
            </div>
            <div class=""row"">
                <!-- Start Portfolio -page -->
                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                    <ul id=""portfolio-flters"">
");
            EndContext();
#line 18 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
                         for (var i = 0; i < Model.Count; i++)
                        {

#line default
#line hidden
            BeginContext(764, 31, true);
            WriteLiteral("                            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 795, "\"", 831, 1);
#line 20 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
WriteAttributeValue("", 803, i==0? "filter-active": "", 803, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(832, 15, true);
            WriteLiteral(" data-filter=\".");
            EndContext();
            BeginContext(848, 15, false);
#line 20 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
                                                                              Write(Model[i].Filter);

#line default
#line hidden
            EndContext();
            BeginContext(863, 36, true);
            WriteLiteral("\">\r\n                                ");
            EndContext();
            BeginContext(900, 15, false);
#line 21 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
                           Write(Model[i].Header);

#line default
#line hidden
            EndContext();
            BeginContext(915, 37, true);
            WriteLiteral("\r\n                            </li>\r\n");
            EndContext();
#line 23 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(979, 127, true);
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\" id=\"portfolio-wrapper\">\r\n");
            EndContext();
#line 29 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1171, 20, true);
            WriteLiteral("                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1191, "\"", 1261, 5);
            WriteAttributeValue("", 1199, "col-lg-10", 1199, 9, true);
            WriteAttributeValue(" ", 1208, "col-lg-offset-1", 1209, 16, true);
            WriteAttributeValue(" ", 1224, "col-md-6", 1225, 9, true);
            WriteAttributeValue(" ", 1233, "portfolio-item", 1234, 15, true);
#line 31 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
WriteAttributeValue(" ", 1248, item.Filter, 1249, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1262, 27, true);
            WriteLiteral(">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1289, "\"", 1307, 1);
#line 32 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
WriteAttributeValue("", 1295, item.Images, 1295, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1308, 81, true);
            WriteLiteral(" alt=\"\">\r\n                    <div class=\"details\">\r\n                        <h4>");
            EndContext();
            BeginContext(1390, 11, false);
#line 34 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
                       Write(item.Header);

#line default
#line hidden
            EndContext();
            BeginContext(1401, 37, true);
            WriteLiteral("</h4>\r\n                        <span>");
            EndContext();
            BeginContext(1439, 16, false);
#line 35 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
                         Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1455, 61, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 38 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(1535, 84, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <!-- awesome-portfolio end -->\r\n");
            EndContext();
#line 43 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DesignDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
