#pragma checksum "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/Pages/Authentication.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "674ee98c024ef3c3a673d90b47479b76dad82e83"
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
#line 2 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/Pages/Authentication.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authentication/{action}")]
    public partial class Authentication : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.WebAssembly.Authentication.RemoteAuthenticatorView>(0);
            __builder.AddAttribute(1, "Action", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/Pages/Authentication.razor"
                                  Action

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "/Users/michalpapinski/Desktop/aws_sample/src/Cloud/Presentation/FXbox.Cloud.Presentation.BackOffice/Pages/Authentication.razor"
      
    [Parameter] public string Action { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
