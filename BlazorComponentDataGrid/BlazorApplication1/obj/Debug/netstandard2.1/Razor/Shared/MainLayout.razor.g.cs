#pragma checksum "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5555bea369771e9b73b3c2edf357c746fab3411"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorComponentDataGrid.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using BlazorComponentDataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using BlazorComponentDataGrid.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorComponentDataGrid.Shared.Header>(0);
            __builder.AddAttribute(1, "StateCssClass", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\Shared\MainLayout.razor"
                              NavMenuCssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "StateCssClassChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NavMenuCssClass = __value, NavMenuCssClass))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "sidebar" + " " + (
#nullable restore
#line 6 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\Shared\MainLayout.razor"
                         NavMenuCssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenComponent<BlazorComponentDataGrid.Shared.NavMenu>(10);
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "content px-4");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddContent(16, 
#nullable restore
#line 10 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\Shared\MainLayout.razor"
      
    string NavMenuCssClass { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591