#pragma checksum "C:\Users\EIS\Documents\GitHub\.Net-Core-Drink\Drinks_App\Views\Shared\DrinksSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a2ccb1694dad7aa9a6c7c5421c2e8d704c8a32c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DrinksSummary), @"mvc.1.0.view", @"/Views/Shared/DrinksSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/DrinksSummary.cshtml", typeof(AspNetCore.Views_Shared_DrinksSummary))]
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
#line 1 "C:\Users\EIS\Documents\GitHub\.Net-Core-Drink\Drinks_App\Views\_ViewImports.cshtml"
using Drinks_App.ViewModel;

#line default
#line hidden
#line 2 "C:\Users\EIS\Documents\GitHub\.Net-Core-Drink\Drinks_App\Views\_ViewImports.cshtml"
using Drinks_App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a2ccb1694dad7aa9a6c7c5421c2e8d704c8a32c", @"/Views/Shared/DrinksSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64414b422db87290e55761d63f895fa204eb82b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DrinksSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 83, true);
            WriteLiteral("<div class=\"col-sm-4 col-lg-4 col-md-6\">\r\n    <div class=\"thumbnail\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 83, "\"", 113, 1);
#line 3 "C:\Users\EIS\Documents\GitHub\.Net-Core-Drink\Drinks_App\Views\Shared\DrinksSummary.cshtml"
WriteAttributeValue("", 89, Model.ImageThumbnailUrl, 89, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(114, 92, true);
            WriteLiteral(" alt=\"Alternate Text\" />\r\n        <div class=\"caption\">\r\n            <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(207, 25, false);
#line 5 "C:\Users\EIS\Documents\GitHub\.Net-Core-Drink\Drinks_App\Views\Shared\DrinksSummary.cshtml"
                              Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(232, 44, true);
            WriteLiteral("</h3>\r\n            <h3>\r\n                <a>");
            EndContext();
            BeginContext(277, 10, false);
#line 7 "C:\Users\EIS\Documents\GitHub\.Net-Core-Drink\Drinks_App\Views\Shared\DrinksSummary.cshtml"
              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(287, 40, true);
            WriteLiteral("</a>\r\n            </h3>\r\n            <p>");
            EndContext();
            BeginContext(328, 22, false);
#line 9 "C:\Users\EIS\Documents\GitHub\.Net-Core-Drink\Drinks_App\Views\Shared\DrinksSummary.cshtml"
          Write(Model.ShortDescripcion);

#line default
#line hidden
            EndContext();
            BeginContext(350, 40, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>");
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
