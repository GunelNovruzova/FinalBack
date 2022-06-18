#pragma checksum "C:\Users\User\Desktop\PriveFinal\Final\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df3fbe982f847b176e2004f72e637396a48a01d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df3fbe982f847b176e2004f72e637396a48a01d8", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a437baa4820bc8d9fe72342d1023ce00483fc0df", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\PriveFinal\Final\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"contact\">\r\n    <div class=\"contact-text\">\r\n        <h1>Contact Us</h1>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 159, "\"", 166, 0);
            EndWriteAttribute();
            WriteLiteral(@">Home </a>
        <i class=""fa-solid fa-angle-right""></i>
        <span>Contact Us</span>
    </div>
</section>
<section  class=""booking"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-5  col-sm-5 form-text"">
                <h3>Contact Us</h3>
                ");
#nullable restore
#line 19 "C:\Users\User\Desktop\PriveFinal\Final\Views\Contact\Index.cshtml"
           Write(await Html.PartialAsync("_ContatctCreatePartial", Model.Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </div>\r\n            <div class=\"col-lg-6 col-md-7 col-sm-7\">\r\n                <h5>Our Contacts</h5>\r\n                <h2>");
#nullable restore
#line 23 "C:\Users\User\Desktop\PriveFinal\Final\Views\Contact\Index.cshtml"
               Write(Model.Setting.ContactUsTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>");
#nullable restore
#line 24 "C:\Users\User\Desktop\PriveFinal\Final\Views\Contact\Index.cshtml"
              Write(Html.Raw(Model.Setting.ContactUsDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"contactdetails\">\r\n                    <i class=\"fa-solid fa-location-dot\"></i>\r\n                    <p>\r\n                        We are Here:\r\n                        <br />\r\n                       ");
#nullable restore
#line 30 "C:\Users\User\Desktop\PriveFinal\Final\Views\Contact\Index.cshtml"
                  Write(Model.Setting.Address);

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
#line 38 "C:\Users\User\Desktop\PriveFinal\Final\Views\Contact\Index.cshtml"
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
#line 46 "C:\Users\User\Desktop\PriveFinal\Final\Views\Contact\Index.cshtml"
                  Write(Model.Setting.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""map"">
    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3039.656085411035!2d49.83942181535441!3d40.37214947937041!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307dafc71aec4f%3A0xd34c420fcbf89177!2sPrive%20Steak%20Gallery%20Baku!5e0!3m2!1sen!2s!4v1652987366732!5m2!1sen!2s"" width=""1280"" height=""550"" style=""border:0;"" border-radius=""70%""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 2106, "\"", 2124, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactVM> Html { get; private set; }
    }
}
#pragma warning restore 1591