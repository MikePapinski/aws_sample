#pragma checksum "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/Shared/LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7d5100abb62f08e35ae7efbc29af7b533b203a4"
// <auto-generated/>
#pragma warning disable 1591
namespace FXbox.Cloud.Presentation.Agent.Shared
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
#line 1 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/Shared/LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/Shared/LoginDisplay.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\n        Hello, ");
#nullable restore
#line 9 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/Shared/LoginDisplay.razor"
__builder2.AddContent(3, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(4, "!\n        ");
                __builder2.OpenElement(5, "button");
                __builder2.AddAttribute(6, "class", "nav-link btn btn-link");
                __builder2.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/Shared/LoginDisplay.razor"
                                                        BeginSignOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(8, "Log out");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\n    ");
            }
            ));
            __builder.AddAttribute(10, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\n        ");
                __builder2.AddMarkupContent(12, "<a href=\"authentication/login\">Log in</a>\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.Agent/Shared/LoginDisplay.razor"
      
    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        Navigation.NavigateTo("authentication/logout");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591