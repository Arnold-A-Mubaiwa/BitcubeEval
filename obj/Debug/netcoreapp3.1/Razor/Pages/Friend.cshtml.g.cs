#pragma checksum "/home/arnold/Desktop/Codes/ex/BitcubeEval/Pages/Friend.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a197bf72b02ab783f26590e79298f290b8eef2b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BitcubeEval.Pages.Pages_Friend), @"mvc.1.0.razor-page", @"/Pages/Friend.cshtml")]
namespace BitcubeEval.Pages
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
#line 1 "/home/arnold/Desktop/Codes/ex/BitcubeEval/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/arnold/Desktop/Codes/ex/BitcubeEval/Pages/_ViewImports.cshtml"
using BitcubeEval;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/arnold/Desktop/Codes/ex/BitcubeEval/Pages/_ViewImports.cshtml"
using BitcubeEval.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a197bf72b02ab783f26590e79298f290b8eef2b5", @"/Pages/Friend.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c76ab7050da384b462ab05aec0411ae3c0c693", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Friend : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/arnold/Desktop/Codes/ex/BitcubeEval/Pages/Friend.cshtml"
  
    ViewData["Title"] = "Friends";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "/home/arnold/Desktop/Codes/ex/BitcubeEval/Pages/Friend.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Use this page to detail your site\'s Friend policy.</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FriendModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FriendModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FriendModel>)PageContext?.ViewData;
        public FriendModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591