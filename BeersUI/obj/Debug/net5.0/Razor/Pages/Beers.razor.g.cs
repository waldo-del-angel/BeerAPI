#pragma checksum "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b89bb2415c6ec3e8d2e39a2658852be1115e450f"
// <auto-generated/>
#pragma warning disable 1591
namespace BeersUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\odelangel\Projects\Beers\BeersUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\odelangel\Projects\Beers\BeersUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\odelangel\Projects\Beers\BeersUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\odelangel\Projects\Beers\BeersUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\odelangel\Projects\Beers\BeersUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\odelangel\Projects\Beers\BeersUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\odelangel\Projects\Beers\BeersUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\odelangel\Projects\Beers\BeersUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\odelangel\Projects\Beers\BeersUI\_Imports.razor"
using BeersUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\odelangel\Projects\Beers\BeersUI\_Imports.razor"
using BeersUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\odelangel\Projects\Beers\BeersUI\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
using BeerAPI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
using Refit;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/beers")]
    public partial class Beers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>BeersUI</h1>");
#nullable restore
#line 13 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
 if (!string.IsNullOrEmpty(_messageError))
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudAlert>(1);
            __builder.AddAttribute(2, "Severity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Severity>(
#nullable restore
#line 15 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
                        Severity.Error

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, 
#nullable restore
#line 15 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
                                         _messageError

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 16 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
 if (!_loading)
{

#line default
#line hidden
#nullable disable
            __Blazor.BeersUI.Pages.Beers.TypeInference.CreateMudTable_0(__builder, 5, 6, 
#nullable restore
#line 20 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
                      _beers

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 20 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
                                     true

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 20 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
                                                       Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 9, 
#nullable restore
#line 20 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
                                                                                _loading

#line default
#line hidden
#nullable disable
            , 10, 
#nullable restore
#line 20 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
                                                                                                                Color.Info

#line default
#line hidden
#nullable disable
            , 11, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(14, "ID");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(16);
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(18, "BEER");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(20);
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(22, "TRADEMARK");
                }
                ));
                __builder2.CloseComponent();
            }
            , 23, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(24);
                __builder2.AddAttribute(25, "DataLabel", "Nr");
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(27, 
#nullable restore
#line 27 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
                                   context.IdBeer

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(29);
                __builder2.AddAttribute(30, "DataLabel", "Sign");
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(32, 
#nullable restore
#line 28 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
                                     context.Name

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(34);
                __builder2.AddAttribute(35, "DataLabel", "Name");
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(37, 
#nullable restore
#line 29 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
                                     context.IdTradeMark

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 32 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudProgressLinear>(38);
            __builder.AddAttribute(39, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 35 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
                              Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "Indeterminate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "Class", "my-7");
            __builder.CloseComponent();
#nullable restore
#line 36 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\Beers.razor"
       
    private IEnumerable<Beer> _beers;
    private bool _loading = true;
    private string _messageError = "";

    protected override async Task OnInitializedAsync()
    {
        try
        {
            var gitHubApi = RestService.For<IBeerService>("https://localhost:44373/");
            _beers = await gitHubApi.GetBeers();
            _loading = false;
        }
        catch (Exception _)
        {
            _messageError = _.Message;
            _loading = false;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
    }
}
namespace __Blazor.BeersUI.Pages.Beers
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::MudBlazor.Color __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "Breakpoint", __arg2);
        __builder.AddAttribute(__seq3, "Loading", __arg3);
        __builder.AddAttribute(__seq4, "LoadingProgressColor", __arg4);
        __builder.AddAttribute(__seq5, "HeaderContent", __arg5);
        __builder.AddAttribute(__seq6, "RowTemplate", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591