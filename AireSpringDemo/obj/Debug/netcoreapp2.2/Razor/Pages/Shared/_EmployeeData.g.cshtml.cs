#pragma checksum "/Users/yonathanseleshi/Documents/DemoApps/AirespringDemo/AireSpringDemo/AireSpringDemo/Pages/Shared/_EmployeeData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7605c50b7761a6e57206425fb7adcb6e1c69103c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AireSpringDemo.Pages.Shared.Pages_Shared__EmployeeData), @"mvc.1.0.view", @"/Pages/Shared/_EmployeeData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_EmployeeData.cshtml", typeof(AireSpringDemo.Pages.Shared.Pages_Shared__EmployeeData))]
namespace AireSpringDemo.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/yonathanseleshi/Documents/DemoApps/AirespringDemo/AireSpringDemo/AireSpringDemo/Pages/_ViewImports.cshtml"
using AireSpringDemo;

#line default
#line hidden
#line 1 "/Users/yonathanseleshi/Documents/DemoApps/AirespringDemo/AireSpringDemo/AireSpringDemo/Pages/Shared/_EmployeeData.cshtml"
using AireSpringDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7605c50b7761a6e57206425fb7adcb6e1c69103c", @"/Pages/Shared/_EmployeeData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5e19073327b89649993bf84b0a47cf909b9a4c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__EmployeeData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AireSpringDemo.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 64, true);
            WriteLiteral("\n<div class=\"card\">\n    <div class=\"card-body\">\n        <div>ID:");
            EndContext();
            BeginContext(132, 12, false);
#line 6 "/Users/yonathanseleshi/Documents/DemoApps/AirespringDemo/AireSpringDemo/AireSpringDemo/Pages/Shared/_EmployeeData.cshtml"
           Write(Model.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(144, 31, true);
            WriteLiteral("</div>\n        <div>First Name:");
            EndContext();
            BeginContext(176, 15, false);
#line 7 "/Users/yonathanseleshi/Documents/DemoApps/AirespringDemo/AireSpringDemo/AireSpringDemo/Pages/Shared/_EmployeeData.cshtml"
                   Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(191, 30, true);
            WriteLiteral("</div>\n        <div>Last Name:");
            EndContext();
            BeginContext(222, 14, false);
#line 8 "/Users/yonathanseleshi/Documents/DemoApps/AirespringDemo/AireSpringDemo/AireSpringDemo/Pages/Shared/_EmployeeData.cshtml"
                  Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(236, 34, true);
            WriteLiteral("</div>\n        <div>Phone Number: ");
            EndContext();
            BeginContext(271, 17, false);
#line 9 "/Users/yonathanseleshi/Documents/DemoApps/AirespringDemo/AireSpringDemo/AireSpringDemo/Pages/Shared/_EmployeeData.cshtml"
                      Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(288, 31, true);
            WriteLiteral("</div>\n        <div>Hire Date: ");
            EndContext();
            BeginContext(320, 14, false);
#line 10 "/Users/yonathanseleshi/Documents/DemoApps/AirespringDemo/AireSpringDemo/AireSpringDemo/Pages/Shared/_EmployeeData.cshtml"
                   Write(Model.HireDate);

#line default
#line hidden
            EndContext();
            BeginContext(334, 24, true);
            WriteLiteral("</div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AireSpringDemo.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
