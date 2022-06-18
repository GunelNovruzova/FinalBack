#pragma checksum "C:\Users\User\Desktop\PriveFinal\Final\Views\Table\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f48d710e3191e9c639dfd54aae2a7f72874d85f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table_Index), @"mvc.1.0.view", @"/Views/Table/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Table;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f48d710e3191e9c639dfd54aae2a7f72874d85f", @"/Views/Table/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a437baa4820bc8d9fe72342d1023ce00483fc0df", @"/Views/_ViewImports.cshtml")]
    public class Views_Table_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TableVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\PriveFinal\Final\Views\Table\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"about\">\r\n    <div class=\"about-text\">\r\n        <h1>Book a Table</h1>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 155, "\"", 162, 0);
            EndWriteAttribute();
            WriteLiteral(@">Home </a>
        <i class=""fa-solid fa-angle-right""></i>
        <span>Book a Table</span>
    </div>
</section>
<section class=""booking"">
    <div class=""container"">
        <div class=""row"">
       <div class=""col-lg-8 form-text"">
                <h3>Book A Table</h3>
             ");
#nullable restore
#line 19 "C:\Users\User\Desktop\PriveFinal\Final\Views\Table\Index.cshtml"
        Write(await Html.PartialAsync("_TableCreatePartial", Model.Table));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-4\">\r\n                <h5>Our Contacts</h5>\r\n                <h2>");
#nullable restore
#line 23 "C:\Users\User\Desktop\PriveFinal\Final\Views\Table\Index.cshtml"
               Write(Model.Setting.ContactUsTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>");
#nullable restore
#line 24 "C:\Users\User\Desktop\PriveFinal\Final\Views\Table\Index.cshtml"
              Write(Html.Raw(Model.Setting.ContactUsDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"contactdetails\">\r\n                    <i class=\"fa-solid fa-location-dot\"></i>\r\n                    <p>\r\n                        We are Here:\r\n                        <br>\r\n                       ");
#nullable restore
#line 30 "C:\Users\User\Desktop\PriveFinal\Final\Views\Table\Index.cshtml"
                  Write(Html.Raw(Model.Setting.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
                <div class=""contactdetails"">
                    <i class=""fa-solid fa-phone""></i>
                    <p>
                        Phone Us:
                        <br>
                        ");
#nullable restore
#line 38 "C:\Users\User\Desktop\PriveFinal\Final\Views\Table\Index.cshtml"
                   Write(Model.Setting.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
                <div class=""contactdetails"">
                    <i class=""fa-solid fa-at""></i>
                    <p>
                        Mail Us:
                        <br>
                        ");
#nullable restore
#line 46 "C:\Users\User\Desktop\PriveFinal\Final\Views\Table\Index.cshtml"
                   Write(Model.Setting.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TableVM> Html { get; private set; }
    }
}
#pragma warning restore 1591