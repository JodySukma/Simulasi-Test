#pragma checksum "E:\Pelatihan\Tugas\Tugas_Simulasi_Tes_Alkademi\Tugas Web\Rumah_Idaman\Rumah_Idaman\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38bd68beec45296803aa22c84eaceb7c3fc80b47"
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
#line 1 "E:\Pelatihan\Tugas\Tugas_Simulasi_Tes_Alkademi\Tugas Web\Rumah_Idaman\Rumah_Idaman\Views\_ViewImports.cshtml"
using Rumah_Idaman;

#line default
#line hidden
#line 2 "E:\Pelatihan\Tugas\Tugas_Simulasi_Tes_Alkademi\Tugas Web\Rumah_Idaman\Rumah_Idaman\Views\_ViewImports.cshtml"
using Rumah_Idaman.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38bd68beec45296803aa22c84eaceb7c3fc80b47", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0d837226ce39b985ccd69ca8613205278167744", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Pelatihan\Tugas\Tugas_Simulasi_Tes_Alkademi\Tugas Web\Rumah_Idaman\Rumah_Idaman\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 852, true);
            WriteLiteral(@"
<style>    
    #map {
        height: 400px;
        width:400px;
    }
</style>

<div class=""text-center"">
    <div id=""map""></div>
    <script>
      var map;
      function initMap() {
        map = new google.maps.Map(document.getElementById('map'), {
            center: { lat: -6.914744, lng: 107.609810},
          zoom: 15
          });

          var marker = new google.maps.Marker({
              position: { lat: -6.895364, lng: 107.604799 },
              map: map
          });

          var marker = new google.maps.Marker({
              position: { lat: -6.81167, lng: 107.6175 },
              map: map
          });
      }
    </script>
    <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyBFrIm6PbfrCVAQX9IrSyJtiw6z1Yelo9k&callback=initMap""
            async defer></script>
</div>
");
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
