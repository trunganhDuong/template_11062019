#pragma checksum "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\BackEnd\Views\Policy\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53e4359352c10b3d20b6ad0a0eaa92a3657ab253"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BackEnd_Views_Policy_Edit), @"mvc.1.0.view", @"/Areas/BackEnd/Views/Policy/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BackEnd/Views/Policy/Edit.cshtml", typeof(AspNetCore.Areas_BackEnd_Views_Policy_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53e4359352c10b3d20b6ad0a0eaa92a3657ab253", @"/Areas/BackEnd/Views/Policy/Edit.cshtml")]
    public class Areas_BackEnd_Views_Policy_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Template_RealEstate_20052019.Models.Article>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/bower_components/ckeditor/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/dist/js/ckfinder/ckfinder.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 128, true);
            WriteLiteral("\r\n<section class=\"content\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"box box-primary\">\r\n");
            EndContext();
#line 7 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\BackEnd\Views\Policy\Edit.cshtml"
                 using (Html.BeginForm(FormMethod.Post, new { enctype = "multipart/form-data" }))
                {

#line default
#line hidden
            BeginContext(298, 68, true);
            WriteLiteral("                    <div class=\"box-body\">\r\n                        ");
            EndContext();
            BeginContext(367, 32, false);
#line 10 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\BackEnd\Views\Policy\Edit.cshtml"
                   Write(Html.HiddenFor(x => x.ArticleId));

#line default
#line hidden
            EndContext();
            BeginContext(399, 80, true);
            WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(480, 34, false);
#line 12 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\BackEnd\Views\Policy\Edit.cshtml"
                       Write(Html.LabelFor(x => x.ArticleTitle));

#line default
#line hidden
            EndContext();
            BeginContext(514, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(545, 69, false);
#line 13 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\BackEnd\Views\Policy\Edit.cshtml"
                       Write(Html.TextBoxFor(x => x.ArticleTitle, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(614, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(645, 82, false);
#line 14 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\BackEnd\Views\Policy\Edit.cshtml"
                       Write(Html.ValidationMessageFor(x => x.ArticleTitle, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(727, 114, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(842, 26, false);
#line 18 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\BackEnd\Views\Policy\Edit.cshtml"
                       Write(Html.LabelFor(x => x.Sapo));

#line default
#line hidden
            EndContext();
            BeginContext(868, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(899, 62, false);
#line 19 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\BackEnd\Views\Policy\Edit.cshtml"
                       Write(Html.TextAreaFor(x => x.Sapo, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(961, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(992, 74, false);
#line 20 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\BackEnd\Views\Policy\Edit.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Sapo, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 114, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1181, 29, false);
#line 24 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\BackEnd\Views\Policy\Edit.cshtml"
                       Write(Html.LabelFor(x => x.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1241, 132, false);
#line 25 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\BackEnd\Views\Policy\Edit.cshtml"
                       Write(Html.TextAreaFor(x => x.Content, new { @id = "editorContent", @style = "display:none, visibility:hidden", @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1404, 77, false);
#line 26 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\BackEnd\Views\Policy\Edit.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Content, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1481, 114, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1596, 29, false);
#line 30 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\BackEnd\Views\Policy\Edit.cshtml"
                       Write(Html.HiddenFor(x => x.Avatar));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1656, 28, false);
#line 31 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\BackEnd\Views\Policy\Edit.cshtml"
                       Write(Html.LabelFor(x => x.Avatar));

#line default
#line hidden
            EndContext();
            BeginContext(1684, 283, true);
            WriteLiteral(@"
                            <input type=""file"" name=""file"" />
                        </div>
                    </div>
                    <div class=""box-footer"">
                        <button type=""submit"" class=""btn btn-primary"">Lưu</button>
                    </div>
");
            EndContext();
#line 38 "D:\Projects\Template_RealEstate_06112019\Template_RealEstate_20052019\Areas\BackEnd\Views\Policy\Edit.cshtml"
                }

#line default
#line hidden
            BeginContext(1986, 62, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2065, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2071, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dd645722a4248c0ac58efdce9bfe34d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2163, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2169, 83, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02347faf71db47fca6a060b8de8522e7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2252, 156, true);
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function(){\r\n            CKEDITOR.replace(\"editorContent\");\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Template_RealEstate_20052019.Models.Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
