#pragma checksum "/Users/alisher/Projects/IdentificationService/ProjectRegistration/Views/Start/Apikey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60e687a4219dcea01807e0bcc0c26d693e1b35a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Start_Apikey), @"mvc.1.0.view", @"/Views/Start/Apikey.cshtml")]
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
#line 1 "/Users/alisher/Projects/IdentificationService/ProjectRegistration/Views/_ViewImports.cshtml"
using ProjectRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alisher/Projects/IdentificationService/ProjectRegistration/Views/_ViewImports.cshtml"
using ProjectRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e687a4219dcea01807e0bcc0c26d693e1b35a4", @"/Views/Start/Apikey.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cebe494c3f0f7b9e85770e714c1ea4d937ebe4ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Start_Apikey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table style=\"width:70%; margin-left: 150px; \">\r\n    <tr>\r\n        <th>Key</th>\r\n        <th>Token</th>\r\n    </tr>\r\n    <tr>\r\n        <td>Server Key</td>\r\n        <td>\r\n");
#nullable restore
#line 11 "/Users/alisher/Projects/IdentificationService/ProjectRegistration/Views/Start/Apikey.cshtml"
             if (@Model.Equals(""))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p></p>\n");
#nullable restore
#line 14 "/Users/alisher/Projects/IdentificationService/ProjectRegistration/Views/Start/Apikey.cshtml"
            } else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/alisher/Projects/IdentificationService/ProjectRegistration/Views/Start/Apikey.cshtml"
           Write(Model);

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/alisher/Projects/IdentificationService/ProjectRegistration/Views/Start/Apikey.cshtml"
                      
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
