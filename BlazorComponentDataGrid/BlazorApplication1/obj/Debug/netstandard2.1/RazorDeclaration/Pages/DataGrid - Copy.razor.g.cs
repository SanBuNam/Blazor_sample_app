// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApplication1.Pages
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
using BlazorApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\_Imports.razor"
using BlazorApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\Pages\DataGrid - Copy.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\Pages\DataGrid - Copy.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid")]
    public partial class DataGrid___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\david.lee\source\repos\BlazorApplication1\BlazorApplication1\Pages\DataGrid - Copy.razor"
       
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public bool Precipitation { get; set; }
        public string CloudCover { get; set; }
    }
    static readonly Random random = new Random();
    readonly ObservableCollection<WeatherForecast> weatherForecasts = new ObservableCollection<WeatherForecast>();

    protected override void OnInitialized()
    {
        String[] CloudCover = { "Sunny", "Partly cloudy", "Cloudy", "Storm" };

        foreach (var date in Enumerable.Range(1, 30).Select(i => DateTime.Now.Date.AddDays(i)))
        {
            weatherForecasts.Add(new WeatherForecast()
            {
                Date = date,
                TemperatureC = random.Next(10, 20),
                Precipitation = Convert.ToBoolean(random.Next(0, 2)),
                CloudCover = CloudCover[random.Next(0, CloudCover.Length)]
            });
        }
    }

    void OnRowInserting(Dictionary<string, object> itemProperties)
    {
        weatherForecasts.Add(UpdateItem(new WeatherForecast(), itemProperties));
    }
    void OnRowDeleting(WeatherForecast item)
    {
        weatherForecasts.Remove(item);
    }
    void OnRowUpdating(WeatherForecast item, Dictionary<string, object> itemProperties)
    {
        UpdateItem(item, itemProperties);
    }

    Task OnInitNewRow(Dictionary<string, object> values)
    {
        values.Add("Date", DateTime.Now);
        values.Add("TemperatureC", 13);
        values.Add("CloudCover", "Sunny");
        return Task.CompletedTask;
    }

    static WeatherForecast UpdateItem(WeatherForecast item, Dictionary<string, object> itemProperties)
    {
        foreach (var field in itemProperties.Keys)
        {
            switch (field)
            {
                case "Date":
                    item.Date = (DateTime)itemProperties[nameof(WeatherForecast.Date)];
                    break;
                case "TemperatureC":
                    item.TemperatureC = (int)itemProperties[nameof(WeatherForecast.TemperatureC)];
                    break;
                case "Precipitation":
                    item.Precipitation = (bool)itemProperties[nameof(WeatherForecast.Precipitation)];
                    break;
            }
        }
        return item;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
