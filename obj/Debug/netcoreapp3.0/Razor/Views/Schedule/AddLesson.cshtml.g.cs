#pragma checksum "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddLesson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ddad2607b3d4d33eacd1de6bd45579696cf4d5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedule_AddLesson), @"mvc.1.0.view", @"/Views/Schedule/AddLesson.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ddad2607b3d4d33eacd1de6bd45579696cf4d5c", @"/Views/Schedule/AddLesson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a1ec3d6fbaa4e724ec210c3c6ef4ee28b939e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Schedule_AddLesson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<byte>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddLesson.cshtml"
  Layout = null;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"border-bottom: 2px solid green; border-top: 2px solid green; padding: 5% 0;\">\r\n    <div class=\"form-group\">\r\n        <label");
            BeginWriteAttribute("for", " for=\"", 173, "\"", 222, 3);
            WriteAttributeValue("", 179, "ScheduleDays[", 179, 13, true);
#nullable restore
#line 6 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddLesson.cshtml"
WriteAttributeValue("", 192, Model, 192, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 198, "].Lessons[].LessonNumber", 198, 24, true);
            EndWriteAttribute();
            WriteLiteral(">Номер заняття</label>\r\n        <input class=\"form-control\"");
            BeginWriteAttribute("name", " name=\"", 282, "\"", 332, 3);
            WriteAttributeValue("", 289, "ScheduleDays[", 289, 13, true);
#nullable restore
#line 7 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddLesson.cshtml"
WriteAttributeValue("", 302, Model, 302, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 308, "].Lessons[].LessonNumber", 308, 24, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 333, "\"", 381, 3);
            WriteAttributeValue("", 338, "ScheduleDays[", 338, 13, true);
#nullable restore
#line 7 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddLesson.cshtml"
WriteAttributeValue("", 351, Model, 351, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 357, "].Lessons[].LessonNumber", 357, 24, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"number\"");
            BeginWriteAttribute("value", " value=\"", 396, "\"", 404, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label");
            BeginWriteAttribute("for", " for=\"", 466, "\"", 507, 3);
            WriteAttributeValue("", 472, "ScheduleDays[", 472, 13, true);
#nullable restore
#line 11 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddLesson.cshtml"
WriteAttributeValue("", 485, Model, 485, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 491, "].Lessons[].Name", 491, 16, true);
            EndWriteAttribute();
            WriteLiteral(">Назва заняття</label>\r\n        <input class=\"form-control\"");
            BeginWriteAttribute("name", " name=\"", 567, "\"", 609, 3);
            WriteAttributeValue("", 574, "ScheduleDays[", 574, 13, true);
#nullable restore
#line 12 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddLesson.cshtml"
WriteAttributeValue("", 587, Model, 587, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 593, "].Lessons[].Name", 593, 16, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 610, "\"", 650, 3);
            WriteAttributeValue("", 615, "ScheduleDays[", 615, 13, true);
#nullable restore
#line 12 "C:\Users\misha\Desktop\Project\IFNMUSIte\IFNMUSiteCore\Views\Schedule\AddLesson.cshtml"
WriteAttributeValue("", 628, Model, 628, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 634, "].Lessons[].Name", 634, 16, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 663, "\"", 671, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n</div>\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<byte> Html { get; private set; }
    }
}
#pragma warning restore 1591