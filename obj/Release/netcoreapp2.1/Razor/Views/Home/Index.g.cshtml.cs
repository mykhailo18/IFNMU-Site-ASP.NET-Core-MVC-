#pragma checksum "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0c1afdf171666de6a714d53bf0cecbd69aa5453"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\_ViewImports.cshtml"
using IFNMUSiteCore;

#line default
#line hidden
#line 2 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\_ViewImports.cshtml"
using IFNMUSiteCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0c1afdf171666de6a714d53bf0cecbd69aa5453", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a1ec3d6fbaa4e724ec210c3c6ef4ee28b939e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Schedule";

#line default
#line hidden
#line 4 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
  Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(86, 38, true);
            WriteLiteral("    <div class=\"containerQuestions\">\r\n");
            EndContext();
#line 6 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
          
            byte number = 0;
            foreach (var i in ViewBag.Questions)
            {

#line default
#line hidden
            BeginContext(231, 20, true);
            WriteLiteral("                <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 251, "\"", 267, 1);
#line 10 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
WriteAttributeValue("", 256, ++number, 256, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(268, 55, true);
            WriteLiteral(" class=\"question\">\r\n                    <h3>Запитання №");
            EndContext();
            BeginContext(325, 6, false);
#line 11 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
                               Write(number);

#line default
#line hidden
            EndContext();
            BeginContext(332, 57, true);
            WriteLiteral("</h3>\r\n                    <h4>\r\n                        ");
            EndContext();
            BeginContext(390, 14, false);
#line 13 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
                   Write(i.QuestionText);

#line default
#line hidden
            EndContext();
            BeginContext(404, 89, true);
            WriteLiteral("\r\n                    </h4>\r\n                    <p class=\"hoverAnswer\" data-trueAnswer=\"");
            EndContext();
            BeginContext(495, 43, false);
#line 15 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
                                                        Write(i.Answers[0].TrueAnswer == 1 ? true : false);

#line default
#line hidden
            EndContext();
            BeginContext(539, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(542, 17, false);
#line 15 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
                                                                                                       Write(i.Answers[0].Text);

#line default
#line hidden
            EndContext();
            BeginContext(559, 66, true);
            WriteLiteral("</p>\r\n                    <p class=\"hoverAnswer\" data-trueAnswer=\"");
            EndContext();
            BeginContext(627, 43, false);
#line 16 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
                                                        Write(i.Answers[1].TrueAnswer == 1 ? true : false);

#line default
#line hidden
            EndContext();
            BeginContext(671, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(674, 17, false);
#line 16 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
                                                                                                       Write(i.Answers[1].Text);

#line default
#line hidden
            EndContext();
            BeginContext(691, 66, true);
            WriteLiteral("</p>\r\n                    <p class=\"hoverAnswer\" data-trueAnswer=\"");
            EndContext();
            BeginContext(759, 43, false);
#line 17 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
                                                        Write(i.Answers[2].TrueAnswer == 1 ? true : false);

#line default
#line hidden
            EndContext();
            BeginContext(803, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(806, 17, false);
#line 17 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
                                                                                                       Write(i.Answers[2].Text);

#line default
#line hidden
            EndContext();
            BeginContext(823, 66, true);
            WriteLiteral("</p>\r\n                    <p class=\"hoverAnswer\" data-trueAnswer=\"");
            EndContext();
            BeginContext(891, 43, false);
#line 18 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
                                                        Write(i.Answers[3].TrueAnswer == 1 ? true : false);

#line default
#line hidden
            EndContext();
            BeginContext(935, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(938, 17, false);
#line 18 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
                                                                                                       Write(i.Answers[3].Text);

#line default
#line hidden
            EndContext();
            BeginContext(955, 66, true);
            WriteLiteral("</p>\r\n                    <p class=\"hoverAnswer\" data-trueAnswer=\"");
            EndContext();
            BeginContext(1023, 43, false);
#line 19 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
                                                        Write(i.Answers[4].TrueAnswer == 1 ? true : false);

#line default
#line hidden
            EndContext();
            BeginContext(1067, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(1070, 17, false);
#line 19 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
                                                                                                       Write(i.Answers[4].Text);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 30, true);
            WriteLiteral("</p>\r\n                </div>\r\n");
            EndContext();
#line 21 "C:\Users\asus\Desktop\Projects (1)\IFNMUSIte\IFNMUSiteCore\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1143, 12, true);
            WriteLiteral("    </div>\r\n");
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
