#pragma checksum "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Views\Shared\_BoxCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31033272bdcc33e116a6893b7dd641c145999b1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BoxCourse), @"mvc.1.0.view", @"/Views/Shared/_BoxCourse.cshtml")]
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
#line 1 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Views\_ViewImports.cshtml"
using TopLearnProject2022;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Views\_ViewImports.cshtml"
using TopLearnProject2022.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31033272bdcc33e116a6893b7dd641c145999b1e", @"/Views/Shared/_BoxCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af5325403a7be638dab6206b59b72c458e397346", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__BoxCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TopLearn.Core.DTOs.Course.ShowCourseListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" 
 
    <div class=""col-lg-2 col-md-4 col-sm-4 col-xs-6 "">
        <div class=""panel panel-default card-view pa-0"">
            <div class=""panel-wrapper collapse in"">
                <div class=""panel-body pa-0"">
                    <article class=""col-item"">
                        <div class=""photo"">
");
            WriteLiteral("\r\n                            <a href=\"javascript:void(0);\"> <img");
            BeginWriteAttribute("src", " src=\"", 886, "\"", 922, 2);
            WriteAttributeValue("", 892, "/Course/Image/", 892, 14, true);
#nullable restore
#line 18 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Views\Shared\_BoxCourse.cshtml"
WriteAttributeValue("", 906, Model.ImageName, 906, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:120px; height:120px;\" class=\"img-responsive thumbnail\" alt=\"Product Image\" /> </a>\r\n                        </div>\r\n                        <div class=\"info\">\r\n                            <h6>");
#nullable restore
#line 21 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Views\Shared\_BoxCourse.cshtml"
                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <div class=\"product-rating inline-block\">\r\n");
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 1712, "\"", 1753, 2);
            WriteAttributeValue("", 1719, "/Course/ShowCourse/", 1719, 19, true);
#nullable restore
#line 24 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Views\Shared\_BoxCourse.cshtml"
WriteAttributeValue("", 1738, Model.CourseId, 1738, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"font-14 txt-danger\">جزئیات محصول</a>\r\n                            </div>\r\n                            <span class=\"head-font block   font-14\" style=\"color:green\">قیمت: ");
#nullable restore
#line 26 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Views\Shared\_BoxCourse.cshtml"
                                                                                          Write((Model.Price==0)? "رایگان" :Model.Price.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" هزارتومان </span>\r\n                        </div>\r\n                    </article>\r\n                </div>\r\n            </div>\r\n        </div>\r\n \r\n</div>\r\n\r\n<!-- /Product Row Four -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLearn.Core.DTOs.Course.ShowCourseListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
