#pragma checksum "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bccec771656b7c15de809ae9ba5cbdc02a4794e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Users_ListDeleteUsers), @"mvc.1.0.razor-page", @"/Pages/Admin/Users/ListDeleteUsers.cshtml")]
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
#line 1 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\_ViewImports.cshtml"
using TopLearnProject2022;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\_ViewImports.cshtml"
using TopLearnProject2022.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml"
using Toplearn.Core.Convertors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bccec771656b7c15de809ae9ba5cbdc02a4794e7", @"/Pages/Admin/Users/ListDeleteUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af5325403a7be638dab6206b59b72c458e397346", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin_Users_ListDeleteUsers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "ListDeleteUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:aliceblue;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml"
  
    Layout = "_Layout2";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bccec771656b7c15de809ae9ba5cbdc02a4794e75161", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>قالب مدیریتی Gramos</title>

    <!-- begin::global styles -->
    <link rel=""stylesheet"" href=""/assets/vendors/bundle.css"" type=""text/css"">
    <!-- end::global styles -->
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.7.2/font/bootstrap-icons.css"">
    <link rel=""stylesheet"" href=""/assets/vendors/swiper/swiper.min.css"">

    <!-- begin::custom styles -->
    <link rel=""stylesheet"" href=""/assets/css/app.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/assets/css/custom.css"" type=""text/css"">
    <!-- end::custom styles -->
    <!-- begin::favicon -->
    <link rel=""shortcut icon"" href=""/assets/media/image/favicon.png"">
    <!-- end::favicon -->
    <!-- begin::theme color -->
    <meta name=""theme-color"" content=""#3f51b5"" />
    <!-- end::theme color -->

");
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
            WriteLiteral("\r\n\r\n<p>لیست کاربران</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bccec771656b7c15de809ae9ba5cbdc02a4794e77194", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <input name=""username"" type=""text"" class=""form-control col-3"" placeholder=""نام کاربری"" aria-label=""Recipient's username"" aria-describedby=""button-addon2"">
        <div class=""col-1""></div>
        <input name=""filteremail"" type=""text"" class=""form-control col-3"" placeholder=""ایمیل"" aria-label=""Recipient's username"" aria-describedby=""button-addon2"">
        <div class=""col-1""></div>
        <div>
            <button type=""submit"" class=""btn btn-primary"">جستجو</button>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bccec771656b7c15de809ae9ba5cbdc02a4794e78005", async() => {
                    WriteLiteral(" ریست کردن جدول");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""card-body"">
    <div class=""table-responsive"" tabindex=""1"" style=""overflow: hidden; outline: none;"">
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">نام کاربری</th>
                    <th scope=""col"">ایمیل</th>
                    <th scope=""col""> وضعیت حساب کاربری</th>
                    <th scope=""col"">تاریخ ثبت نام</th>
                    <th scope=""col"">دستورات</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 63 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml"
                 foreach (var user in Model.USerForAdminViewModel.Users.Where(i => i.IsDelete == true))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 67 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml"
                       Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 68 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml"
                       Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 70 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml"
                             if (user.IsActive)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"text-success\">فعال</p>\r\n");
#nullable restore
#line 73 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"text-danger\">غیر فعال</p>\r\n");
#nullable restore
#line 77 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>");
#nullable restore
#line 80 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml"
                       Write(user.RegistersDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>\r\n");
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 87 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <nav aria-label=\"...\" class=\"mb-3\">\r\n        <ul class=\"pagination pagination-sm\">\r\n");
#nullable restore
#line 98 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml"
             for (int i = 1; i <= Model.USerForAdminViewModel.PageCount; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 3766, "\"", 3843, 2);
            WriteAttributeValue("", 3774, "page-item", 3774, 9, true);
#nullable restore
#line 100 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml"
WriteAttributeValue(" ", 3783, (i==Model.USerForAdminViewModel.CurrentPage)?"active":"", 3784, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3887, "\"", 3932, 2);
            WriteAttributeValue("", 3894, "/Admin/Users/ListDeleteUsers?PageId=", 3894, 36, true);
#nullable restore
#line 101 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml"
WriteAttributeValue("", 3930, i, 3930, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 101 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml"
                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 103 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Users\ListDeleteUsers.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </ul>
    </nav>
</div>

<script src=""/assets/vendors/bundle.js""></script>
<!-- end::global scripts -->
<!-- begin::chart -->
<script src=""/assets/vendors/charts/chart.min.js""></script>
<script src=""/assets/vendors/charts/sparkline.min.js""></script>
<script src=""/assets/vendors/circle-progress/circle-progress.min.js""></script>
<script src=""/assets/js/examples/charts.js""></script>
<!-- end::chart -->
<!-- begin::swiper -->
<script src=""/assets/vendors/swiper/swiper.min.js""></script>
<script src=""/assets/js/examples/swiper.js""></script>
<!-- begin::custom scripts -->
<script src=""/assets/js/custom.js""></script>
<script src=""/assets/js/app.js""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLearnProject2022.Pages.Admin.Users.ListDeleteUsersModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopLearnProject2022.Pages.Admin.Users.ListDeleteUsersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopLearnProject2022.Pages.Admin.Users.ListDeleteUsersModel>)PageContext?.ViewData;
        public TopLearnProject2022.Pages.Admin.Users.ListDeleteUsersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
