#pragma checksum "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/Pages/Agents.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a359ac341e1ef2b95c34b22d3e296acc586de3e1"
// <auto-generated/>
#pragma warning disable 1591
namespace FXbox.Cloud.Presentation.Agent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/_Imports.razor"
using FXbox.Cloud.Presentation.Agent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/_Imports.razor"
using FXbox.Cloud.Presentation.Agent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/Pages/Agents.razor"
using FXbox.Cloud.Presentation.Agent.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/agents")]
    public partial class Agents : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Agents</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>All active agent nodes and also all registered nodes.</p>\n\n<br>\n\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-bordered");
            __builder.AddMarkupContent(4, "\n  ");
            __builder.AddMarkupContent(5, "<thead>\n    <tr>\n      <th scope=\"col\">Ip</th>\n      <th scope=\"col\">User</th>\n      <th scope=\"col\">Connection</th>\n      <th scope=\"col\">Registration</th>\n      <th scope=\"col\">Action</th>\n    </tr>\n  </thead>\n  ");
            __builder.OpenElement(6, "tbody");
            __builder.AddMarkupContent(7, "\n    ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\n      ");
            __builder.AddMarkupContent(10, "<td>gegs</td>\n      ");
            __builder.AddMarkupContent(11, "<td>herhee3</td>\n      ");
            __builder.AddMarkupContent(12, "<td>shesh</td>\n      ");
            __builder.AddMarkupContent(13, "<td>ehshe</td>\n      ");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/Pages/Agents.razor"
                                                      e => RedirectToAgent("127,128,52,23")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Control");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n    ");
            __builder.AddMarkupContent(21, "<tr>\n      <td>gegs</td>\n            <td>herhee3</td>\n            <td>shesh</td>\n      <td>ehshe</td>\n      <td><button class=\"btn btn-primary\">Control</button></td>\n    </tr>\n    ");
            __builder.AddMarkupContent(22, "<tr>\n      <td>gegs</td>\n            <td>herhee3</td>\n            <td>shesh</td>\n      <td>ehshe</td>\n      <td><button class=\"btn btn-primary\">Control</button></td>\n    </tr>\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/Pages/Agents.razor"
       
  private void RedirectToAgent(string ip)
  {
    NavManager.NavigateTo($"/agent/{ip}");
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAgentsService AgentsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
