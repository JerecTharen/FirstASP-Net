#pragma checksum "/home/jerec/Learning/ASP-Dot-Net/firstApp/Pages/Login/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4499849555ba6a428abc67e3f5bc413edd71b9cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(firstApp.Pages.Login.Pages_Login_Login), @"mvc.1.0.razor-page", @"/Pages/Login/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Login/Login.cshtml", typeof(firstApp.Pages.Login.Pages_Login_Login), null)]
namespace firstApp.Pages.Login
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/jerec/Learning/ASP-Dot-Net/firstApp/Pages/_ViewImports.cshtml"
using firstApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4499849555ba6a428abc67e3f5bc413edd71b9cd", @"/Pages/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e09cc180cafe4f367f12b642aa31a50ed70c3d36", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Login_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 43, true);
            WriteLiteral("\r\n<h1>This is where the fun begins!!</h1>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginModel>)PageContext?.ViewData;
        public LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591