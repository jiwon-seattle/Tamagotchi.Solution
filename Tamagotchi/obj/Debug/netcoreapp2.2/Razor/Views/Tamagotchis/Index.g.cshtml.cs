#pragma checksum "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f4b92ae9222de8ef1faa89a85ed9ac26e5a63aa"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f4b92ae9222de8ef1faa89a85ed9ac26e5a63aa", @"/Views/Tamagotchis/Index.cshtml")]
    public class Views_Tamagotchis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(56, 36, true);
            WriteLiteral("  <h1>Your Tamagotchis!</h1>\n  <ul>\n");
            EndContext();
#line 7 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
            BeginContext(125, 39, true);
            WriteLiteral("      <li>You have no Tamagotchis</li>\n");
            EndContext();
#line 10 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(170, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 11 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
     foreach (Tamagotchi tamagotchi in Model)
    {
      if (tamagotchi.GetLife())
      {

#line default
#line hidden
            BeginContext(262, 27, true);
            WriteLiteral("        <li>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 289, "\"", 323, 2);
            WriteAttributeValue("", 296, "/tamagotchis/", 296, 13, true);
#line 16 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
WriteAttributeValue("", 309, tamagotchi.Id, 309, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(324, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(326, 15, false);
#line 16 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
                                             Write(tamagotchi.Name);

#line default
#line hidden
            EndContext();
            BeginContext(341, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(344, 15, false);
#line 16 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
                                                               Write(tamagotchi.Food);

#line default
#line hidden
            EndContext();
            BeginContext(359, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(362, 16, false);
#line 16 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
                                                                                 Write(tamagotchi.Sleep);

#line default
#line hidden
            EndContext();
            BeginContext(378, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(381, 20, false);
#line 16 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
                                                                                                    Write(tamagotchi.Happiness);

#line default
#line hidden
            EndContext();
            BeginContext(401, 19, true);
            WriteLiteral("</a>\n        </li>\n");
            EndContext();
#line 18 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
      }
    }

#line default
#line hidden
            BeginContext(434, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 21 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
     foreach (Tamagotchi tamagotchi in Model)
    {
      if(@tamagotchi.GetLife() == false)
      {

#line default
#line hidden
            BeginContext(536, 23, true);
            WriteLiteral("        <li>\n          ");
            EndContext();
            BeginContext(560, 15, false);
#line 26 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
     Write(tamagotchi.Name);

#line default
#line hidden
            EndContext();
            BeginContext(575, 24, true);
            WriteLiteral(" is dead.\n        </li>\n");
            EndContext();
#line 28 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
      }
    }

#line default
#line hidden
            BeginContext(613, 242, true);
            WriteLiteral("  </ul>\n\n  <form action=\"/tamagotchis/time\" method=\"post\">\n    <button type=\"submit\" name=\"button\">Pass Time</button>\n  </form>\n\n  <a href=\"/tamagotchis/new\">Add A Tamagotchi</a>\n  <a href=\"/tamagotchis/deleteAll\">Delete All Tamagotchis</a>\n\n");
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