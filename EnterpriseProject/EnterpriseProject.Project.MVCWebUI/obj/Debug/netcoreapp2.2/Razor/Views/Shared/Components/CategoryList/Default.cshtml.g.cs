#pragma checksum "C:\Users\Blackerback\Desktop\Komple Uygulamalı Web Geliştirme Eğitimi(Engin)\Kurumsal .Net Core Mvc\EnterpriseProject\EnterpriseProject.Project.MVCWebUI\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a614ded9b95e9444528ab277e17ad0e99e85bdc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CategoryList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CategoryList_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a614ded9b95e9444528ab277e17ad0e99e85bdc8", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79181fb8c786ecb3abf5cd2ee714dc8c377aac18", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EnterpriseProject.Project.MVCWebUI.Models.CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 28, true);
            WriteLiteral("\r\n<div class=\"list-group\">\r\n");
            EndContext();
#line 4 "C:\Users\Blackerback\Desktop\Komple Uygulamalı Web Geliştirme Eğitimi(Engin)\Kurumsal .Net Core Mvc\EnterpriseProject\EnterpriseProject.Project.MVCWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
     foreach (var item in Model.Categories)
    {
        var css = "list-group-item";
        if (item.Id==Model.CurrentCategory)
        {
            css += " active";
        }

#line default
#line hidden
            BeginContext(288, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 298, "\"", 337, 2);
            WriteAttributeValue("", 305, "/Product/Index?category=", 305, 24, true);
#line 11 "C:\Users\Blackerback\Desktop\Komple Uygulamalı Web Geliştirme Eğitimi(Engin)\Kurumsal .Net Core Mvc\EnterpriseProject\EnterpriseProject.Project.MVCWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 329, item.Id, 329, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 338, "\"", 350, 1);
#line 11 "C:\Users\Blackerback\Desktop\Komple Uygulamalı Web Geliştirme Eğitimi(Engin)\Kurumsal .Net Core Mvc\EnterpriseProject\EnterpriseProject.Project.MVCWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 346, css, 346, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(351, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(353, 9, false);
#line 11 "C:\Users\Blackerback\Desktop\Komple Uygulamalı Web Geliştirme Eğitimi(Engin)\Kurumsal .Net Core Mvc\EnterpriseProject\EnterpriseProject.Project.MVCWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(362, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 12 "C:\Users\Blackerback\Desktop\Komple Uygulamalı Web Geliştirme Eğitimi(Engin)\Kurumsal .Net Core Mvc\EnterpriseProject\EnterpriseProject.Project.MVCWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(375, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EnterpriseProject.Project.MVCWebUI.Models.CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591