#pragma checksum "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be053698d881779473ec69985d4655c3e5deb18d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedule_AddScheduleBigTable), @"mvc.1.0.view", @"/Views/Schedule/AddScheduleBigTable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be053698d881779473ec69985d4655c3e5deb18d", @"/Views/Schedule/AddScheduleBigTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a1ec3d6fbaa4e724ec210c3c6ef4ee28b939e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Schedule_AddScheduleBigTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DateTime[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
  
    Layout = null;
    int colspan = Model[1].Subtract(Model[0]).Days + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"table-responsive\"");
            BeginWriteAttribute("style", " style=\"", 132, "\"", 212, 5);
            WriteAttributeValue("", 140, "overflow-x:", 140, 11, true);
            WriteAttributeValue(" ", 151, "auto;", 152, 6, true);
            WriteAttributeValue(" ", 157, "width:", 158, 7, true);
#nullable restore
#line 6 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
WriteAttributeValue("", 164, ViewBag.NewTable == true ? "750px" : "500px", 164, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 211, ";", 211, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <table id=\"generatedTable\" class=\"table-bordered\" style=\"text-align: center;\">\r\n\r\n        <tr>\r\n");
#nullable restore
#line 10 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
             if (ViewBag.NewTable == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td rowspan=\"2\">Назва дисципліни</td>\r\n");
#nullable restore
#line 13 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td style=\"text-transform: uppercase;\"");
            BeginWriteAttribute("colspan", " colspan=\"", 495, "\"", 515, 1);
#nullable restore
#line 14 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
WriteAttributeValue("", 505, colspan, 505, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 14 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
                                                                     Write(Model[0].ToString("MMMM") + (Model[1].Month != Model[0].Month ? "/" + Model[1].ToString("MMMM") : ""));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        </tr>\r\n        <tr>\r\n");
#nullable restore
#line 17 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
             for (var i = Model[0]; i <= Model[1]; i = i.AddDays(1))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td> ");
#nullable restore
#line 19 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
                Write(i.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 20 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 22 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
         for (int a = 0; a < ViewBag.CountRow; a++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr ");
#nullable restore
#line 24 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
            Write(a == 0 ? "class=clone" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n");
#nullable restore
#line 25 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
                 if (ViewBag.NewTable == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"width:500px\"><input class=\"form-control\" required type=\"text\" style=\"width:100%;\" name=\"items[-1]\" /></td>\r\n");
#nullable restore
#line 28 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
                 for (var i = Model[0]; i <= Model[1]; i = i.AddDays(1))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"width:250px\"><input class=\"form-control\" required type=\"text\" style=\"width:100%;\"");
            BeginWriteAttribute("name", " name=\"", 1352, "\"", 1385, 3);
            WriteAttributeValue("", 1359, "items[", 1359, 6, true);
#nullable restore
#line 31 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
WriteAttributeValue("", 1365, ViewBag.SelectDate, 1365, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1384, "]", 1384, 1, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n");
#nullable restore
#line 32 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddScheduleBigTable.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DateTime[]> Html { get; private set; }
    }
}
#pragma warning restore 1591