#pragma checksum "C:\Users\Blackerback\Desktop\Komple Uygulamalı Web Geliştirme Eğitimi(Engin)\Kurumsal .Net Core Mvc\EnterpriseProject\EnterpriseProject.Project.MVCWebUI\Views\Shared\_LayoutAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53a70a5390136d6eb372e1eb00a62f12e300dfb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutAdmin), @"mvc.1.0.view", @"/Views/Shared/_LayoutAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LayoutAdmin.cshtml", typeof(AspNetCore.Views_Shared__LayoutAdmin))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53a70a5390136d6eb372e1eb00a62f12e300dfb1", @"/Views/Shared/_LayoutAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79181fb8c786ecb3abf5cd2ee714dc8c377aac18", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 524, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53a70a5390136d6eb372e1eb00a62f12e300dfb13217", async() => {
                BeginContext(33, 511, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Admin Panel</title>
    <link href=""\node_modules\bootstrap\dist\css\bootstrap.css"" rel=""stylesheet"" />
    <script src=""\node_modules\jquery\dist\jquery.js""></script>
    <script src=""\node_modules\bootstrap\dist\js\bootstrap.js""></script>
    <script src=""\node_modules\jquery-validation\dist\jquery.validate.js""></script>
    <script src=""\node_modules\jquery-validation-unobtrusive\dist\jquery.validate.unobtrusive.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(551, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(553, 1554, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53a70a5390136d6eb372e1eb00a62f12e300dfb14924", async() => {
                BeginContext(559, 1288, true);
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">
        <a class=""navbar-brand"" href=""#"">Navbar</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNavDropdown"" aria-controls=""navbarNavDropdown"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""container"">
            <div class=""collapse navbar-collapse"" id=""navbarNavDropdown"">
                <ul class=""navbar-nav"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""#"">Products Store <span class=""sr-only"">(current)</span></a>
                    </li>
              
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownMenuLink"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Dropdown link
      ");
                WriteLiteral(@"                  </a>
                      
                    </li>
                </ul>
            </div>
        </div>
       
    </nav>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-10"">
                ");
                EndContext();
                BeginContext(1849, 43, false);
#line 40 "C:\Users\Blackerback\Desktop\Komple Uygulamalı Web Geliştirme Eğitimi(Engin)\Kurumsal .Net Core Mvc\EnterpriseProject\EnterpriseProject.Project.MVCWebUI\Views\Shared\_LayoutAdmin.cshtml"
            Write(TempData["message"]!=null?"ürün eklendi":"");

#line default
#line hidden
                EndContext();
                BeginContext(1893, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1912, 12, false);
#line 41 "C:\Users\Blackerback\Desktop\Komple Uygulamalı Web Geliştirme Eğitimi(Engin)\Kurumsal .Net Core Mvc\EnterpriseProject\EnterpriseProject.Project.MVCWebUI\Views\Shared\_LayoutAdmin.cshtml"
           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1924, 176, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                FOOTER\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2107, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
