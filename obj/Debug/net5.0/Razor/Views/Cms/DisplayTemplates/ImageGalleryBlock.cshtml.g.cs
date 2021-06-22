#pragma checksum "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b8703800e30fc020cb2732eecd7387528efe4d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_DisplayTemplates_ImageGalleryBlock), @"mvc.1.0.view", @"/Views/Cms/DisplayTemplates/ImageGalleryBlock.cshtml")]
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
#line 1 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\_ViewImports.cshtml"
using Piranha.AspNetCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\_ViewImports.cshtml"
using NorthwindCms.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
using Piranha.Extend.Blocks;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b8703800e30fc020cb2732eecd7387528efe4d6", @"/Views/Cms/DisplayTemplates/ImageGalleryBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6678a70b82dc05f14c5ff659ec3564cb98c831e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_DisplayTemplates_ImageGalleryBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Piranha.Extend.Blocks.ImageGalleryBlock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
  
    var unique = "gallery-" + Guid.NewGuid().ToString();
    var images = Model.Items
        .Where(i => i.GetType() == typeof(ImageBlock) && ((ImageBlock)i).Body.HasValue)
        .ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div");
            BeginWriteAttribute("id", " id=\"", 279, "\"", 291, 1);
#nullable restore
#line 10 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue("", 284, unique, 284, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"carousel slide gallery-block\" data-ride=\"carousel\">\n    <ol class=\"carousel-indicators\">\n");
#nullable restore
#line 12 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
         for (var n = 0; n < images.Count; n++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li data-target=\"#");
#nullable restore
#line 14 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
                         Write(unique);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-slide-to=\"");
#nullable restore
#line 14 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
                                                 Write(n);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 504, "\"", 537, 1);
#nullable restore
#line 14 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue("", 512, n == 0 ? "active" : "", 512, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></li>\n");
#nullable restore
#line 15 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol>\n    <div class=\"carousel-inner\">\n");
#nullable restore
#line 18 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
         foreach (var item in images)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 662, "\"", 725, 2);
            WriteAttributeValue("", 670, "carousel-item", 670, 13, true);
#nullable restore
#line 20 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue(" ", 683, item == images.First() ? "active" : "", 684, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <img");
            BeginWriteAttribute("src", " src=\"", 748, "\"", 834, 1);
#nullable restore
#line 21 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue("", 754, Url.Content(WebApp.Media.ResizeImage(((ImageBlock)item).Body.Media, 1100, 450)), 754, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\">\n            </div>\n");
#nullable restore
#line 23 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n    <a class=\"carousel-control-prev\"");
            BeginWriteAttribute("href", " href=\"", 935, "\"", 950, 2);
            WriteAttributeValue("", 942, "#", 942, 1, true);
#nullable restore
#line 25 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue("", 943, unique, 943, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" data-slide=\"prev\">\n        <span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\n        <span class=\"sr-only\">Previous</span>\n    </a>\n    <a class=\"carousel-control-next\"");
            BeginWriteAttribute("href", " href=\"", 1152, "\"", 1167, 2);
            WriteAttributeValue("", 1159, "#", 1159, 1, true);
#nullable restore
#line 29 "C:\Code\c#\c#9&.net5\Code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue("", 1160, unique, 1160, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" data-slide=\"next\">\n        <span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\n        <span class=\"sr-only\">Next</span>\n    </a>\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Authorization.IAuthorizationService Auth { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.AspNetCore.Services.IApplicationService WebApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piranha.Extend.Blocks.ImageGalleryBlock> Html { get; private set; }
    }
}
#pragma warning restore 1591
