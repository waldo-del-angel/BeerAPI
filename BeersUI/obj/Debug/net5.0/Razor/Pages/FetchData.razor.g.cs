#pragma checksum "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a9ccb43e910ad20ea31cda6b91f2cd8a7693520"
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
#line 3 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\FetchData.razor"
using BeersUI.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
            __Blazor.BeersUI.Pages.FetchData.TypeInference.CreateMudTable_0(__builder, 2, 3, 
#nullable restore
#line 10 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\FetchData.razor"
                  _forecasts

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 10 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\FetchData.razor"
                                     true

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 10 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\FetchData.razor"
                                                       Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 10 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\FetchData.razor"
                                                                                _loading

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 10 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\FetchData.razor"
                                                                                                                Color.Info

#line default
#line hidden
#nullable disable
            , 8, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(11, "DATE");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(13);
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(15, "TEMP (C)");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(17);
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(19, "TEMP (F)");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(21);
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(23, "SUMMARY");
                }
                ));
                __builder2.CloseComponent();
            }
            , 24, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(25);
                __builder2.AddAttribute(26, "DataLabel", "Nr");
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(28, 
#nullable restore
#line 18 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\FetchData.razor"
                               context.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(30);
                __builder2.AddAttribute(31, "DataLabel", "Sign");
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(33, 
#nullable restore
#line 19 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\FetchData.razor"
                                 context.TemperatureC

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(35);
                __builder2.AddAttribute(36, "DataLabel", "Name");
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(38, 
#nullable restore
#line 20 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\FetchData.razor"
                                 context.TemperatureF

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(40);
                __builder2.AddAttribute(41, "DataLabel", "Position");
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(43, 
#nullable restore
#line 21 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\FetchData.razor"
                                     context.Summary

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\odelangel\Projects\Beers\BeersUI\Pages\FetchData.razor"
       
    private WeatherForecast[] _forecasts;
    private bool _loading = true;
    protected override async Task OnInitializedAsync()
    {
        _forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        _loading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
namespace __Blazor.BeersUI.Pages.FetchData
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