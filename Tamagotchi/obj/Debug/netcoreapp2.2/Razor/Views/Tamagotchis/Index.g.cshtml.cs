#pragma checksum "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc6fcf8bd0d2d4fb38e677669a48f3971cd94893"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tamagotchis_Index), @"mvc.1.0.view", @"/Views/Tamagotchis/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tamagotchis/Index.cshtml", typeof(AspNetCore.Views_Tamagotchis_Index))]
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
#line 4 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
using TamagotchiGame.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6fcf8bd0d2d4fb38e677669a48f3971cd94893", @"/Views/Tamagotchis/Index.cshtml")]
    public class Views_Tamagotchis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(56, 113, true);
            WriteLiteral("  <h1>Your Tamagotchis!</h1>\n  <ul>\n    if (Model.Count == 0)\n    {\n      <li>You have no Tamagotchis</li>\n    }\n");
            EndContext();
#line 11 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
     foreach (Tamagotchi tamagotchi in Model)
    {
      if (tamagotchi.GetLife())
      {

#line default
#line hidden
            BeginContext(261, 27, true);
            WriteLiteral("        <li>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 288, "\"", 322, 2);
            WriteAttributeValue("", 295, "/tamagotchis/", 295, 13, true);
#line 16 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
WriteAttributeValue("", 308, tamagotchi.Id, 308, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(323, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(325, 15, false);
#line 16 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
                                             Write(tamagotchi.Name);

#line default
#line hidden
            EndContext();
            BeginContext(340, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(343, 15, false);
#line 16 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
                                                               Write(tamagotchi.Food);

#line default
#line hidden
            EndContext();
            BeginContext(358, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(361, 16, false);
#line 16 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
                                                                                 Write(tamagotchi.Sleep);

#line default
#line hidden
            EndContext();
            BeginContext(377, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(380, 20, false);
#line 16 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
                                                                                                    Write(tamagotchi.Happiness);

#line default
#line hidden
            EndContext();
            BeginContext(400, 19, true);
            WriteLiteral("</a>\n        </li>\n");
            EndContext();
#line 18 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
      }
    }

#line default
#line hidden
            BeginContext(433, 127, true);
            WriteLiteral("  </ul>\n  <a href=\"/tamagotchis/new\">Add Another Tamagotchi</a>\n  <a href=\"/tamagotchis/deleteAll\">Delete All Tamagotchis</a>\n\n");
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
