#pragma checksum "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/Pages/Logs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7065b0c89e23d121f660ef38844ac4b9a5d3397"
// <auto-generated/>
#pragma warning disable 1591
namespace FXbox.Cloud.Presentation.BackOffice.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/_Imports.razor"
using FXbox.Cloud.Presentation.BackOffice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/_Imports.razor"
using FXbox.Cloud.Presentation.BackOffice.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/Pages/Logs.razor"
using FXbox.Cloud.Presentation.BackOffice.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/logs")]
    public partial class Logs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Infrastructure logs</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>Logs from every service across entire FXbox infrastructure stack. Every single action should be possible to trace here.</p>\n\n<br>\n\n");
            __builder.AddMarkupContent(2, @"<table class=""table table-sm""><thead><tr><th scope=""col"">Timestamp</th>
      <th scope=""col"">Ip</th>
      <th scope=""col"">Service</th>
      <th scope=""col"">User</th>
      <th scope=""col"">Message</th></tr></thead>
  <tbody><tr><td>231</td>
      <td>32134</td>
      <td>gdsga</td>
      <td>gdsga</td>
      <td>gdsga</td></tr>
    <tr><td>231</td>
            <td>32134</td>
            <td>gdsga</td>
            <td>gdsga</td>
            <td>gdsga</td></tr>
    <tr><td>231</td>
            <td>32134</td>
            <td>gdsga</td>
            <td>gdsga</td>
            <td>gdsga</td></tr></tbody></table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogsService LogsService { get; set; }
    }
}
#pragma warning restore 1591
