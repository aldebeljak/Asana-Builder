#pragma checksum "C:\Users\Allison Dobeljak\source\repos\AsanaBuilder\Views\Sequences\ViewSequences.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dcc82b7326d3bffb56dd4f44cb3af013da2fa6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sequences_ViewSequences), @"mvc.1.0.view", @"/Views/Sequences/ViewSequences.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sequences/ViewSequences.cshtml", typeof(AspNetCore.Views_Sequences_ViewSequences))]
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
#line 1 "C:\Users\Allison Dobeljak\source\repos\AsanaBuilder\Views\_ViewImports.cshtml"
using AsanaBuilder;

#line default
#line hidden
#line 2 "C:\Users\Allison Dobeljak\source\repos\AsanaBuilder\Views\_ViewImports.cshtml"
using AsanaBuilder.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dcc82b7326d3bffb56dd4f44cb3af013da2fa6d", @"/Views/Sequences/ViewSequences.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdb5f1b8279738c4a7e6bd32b7fbe479a0283db7", @"/Views/_ViewImports.cshtml")]
    public class Views_Sequences_ViewSequences : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Sequence>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Allison Dobeljak\source\repos\AsanaBuilder\Views\Sequences\ViewSequences.cshtml"
  
    ViewData["Title"] = "ViewSequences";
    Layout = "~/Views/Shared/Layout2.cshtml";

#line default
#line hidden
            BeginContext(121, 39, true);
            WriteLiteral("\r\n<h2>Your Sequences</h2>\r\n<div \r\n     ");
            EndContext();
#line 9 "C:\Users\Allison Dobeljak\source\repos\AsanaBuilder\Views\Sequences\ViewSequences.cshtml"
      foreach (Sequence sequence in Model)
     { 

#line default
#line hidden
            BeginContext(208, 32, true);
            WriteLiteral("         <div>\r\n            <h3>");
            EndContext();
            BeginContext(241, 13, false);
#line 12 "C:\Users\Allison Dobeljak\source\repos\AsanaBuilder\Views\Sequences\ViewSequences.cshtml"
           Write(sequence.Name);

#line default
#line hidden
            EndContext();
            BeginContext(254, 24, true);
            WriteLiteral("</h3>\r\n         </div>\r\n");
            EndContext();
#line 14 "C:\Users\Allison Dobeljak\source\repos\AsanaBuilder\Views\Sequences\ViewSequences.cshtml"
     }

#line default
#line hidden
            BeginContext(286, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Sequence>> Html { get; private set; }
    }
}
#pragma warning restore 1591
