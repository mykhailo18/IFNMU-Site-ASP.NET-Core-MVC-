#pragma checksum "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddRow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53c42ece12188f23f771423fd8f1842998d652a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedule_AddRow), @"mvc.1.0.view", @"/Views/Schedule/AddRow.cshtml")]
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
#line 1 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\_ViewImports.cshtml"
using IFNMUSiteCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\_ViewImports.cshtml"
using IFNMUSiteCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53c42ece12188f23f771423fd8f1842998d652a4", @"/Views/Schedule/AddRow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a1ec3d6fbaa4e724ec210c3c6ef4ee28b939e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Schedule_AddRow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddRow.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n");
#nullable restore
#line 6 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddRow.cshtml"
     for (byte i = 0; i < 41; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>\r\n            <input");
            BeginWriteAttribute("name", " name=\"", 120, "\"", 143, 5);
            WriteAttributeValue("", 127, "item[", 127, 5, true);
#nullable restore
#line 9 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddRow.cshtml"
WriteAttributeValue("", 132, Model, 132, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 138, "][", 138, 2, true);
#nullable restore
#line 9 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddRow.cshtml"
WriteAttributeValue("", 140, i, 140, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 142, "]", 142, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" style=\"width:100%;\" />\r\n        </td>\r\n");
#nullable restore
#line 11 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddRow.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
