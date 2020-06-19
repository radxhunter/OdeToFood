#pragma checksum "C:\Users\Piotr\source\repos\GithubProjects\OdeToFood\OdeToFood\Pages\Restaurants\ClientRestaurants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1467cf276e628553d5d8523dc6dc151e46a91954"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_ClientRestaurants), @"mvc.1.0.razor-page", @"/Pages/Restaurants/ClientRestaurants.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/ClientRestaurants.cshtml", typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_ClientRestaurants), null)]
namespace OdeToFood.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Piotr\source\repos\GithubProjects\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1467cf276e628553d5d8523dc6dc151e46a91954", @"/Pages/Restaurants/ClientRestaurants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81fe10e6c90f307728f15587f1d83247c98c9355", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_ClientRestaurants : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Piotr\source\repos\GithubProjects\OdeToFood\OdeToFood\Pages\Restaurants\ClientRestaurants.cshtml"
  
    ViewData["Title"] = "ClientRestaurants";

#line default
#line hidden
            BeginContext(119, 32, true);
            WriteLiteral("\r\n<h2>ClientRestaurants</h2>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(170, 1261, true);
                WriteLiteral(@"


    <script src=""C:\Users\Radek\source\repos\OdeToFood\OdeToFood\node_modules\datatables.net\js\jquery.dataTables.js""></script>
    <script src=""C:\Users\Radek\source\repos\OdeToFood\OdeToFood\node_modules\datatables.net-bs\js\dataTables.bootstrap.js""></script>
    <link href=""C:\Users\Radek\source\repos\OdeToFood\OdeToFood\node_modules\datatables.net-bs\css\dataTables.bootstrap.css"" rel=""stylesheet""/>


    <script>
        $(function() {

            var cuisines = [""Unknown"", ""Mexican"", ""Italian"", ""Indian""];

            $.ajax(""/api/restaurants/"",
                    { method: ""get"" })
                .then(function(response) {
                    $(""#restaurants"").dataTable({
                        data: response,
                        columns: [
                            { ""data"": ""name"" },
                            { ""data"": ""location"" },
                            {
                                ""data"": ""cuisine"",
                                ""render"": function(d");
                WriteLiteral("ata) {\r\n                                    return cuisines[data];\r\n                                }\r\n                            }\r\n                        ]\r\n                    });\r\n                });\r\n        });\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Pages.Restaurants.ClientRestaurantsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.ClientRestaurantsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.ClientRestaurantsModel>)PageContext?.ViewData;
        public OdeToFood.Pages.Restaurants.ClientRestaurantsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
