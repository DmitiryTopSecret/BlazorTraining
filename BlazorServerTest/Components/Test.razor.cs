
using BlazorServerTest.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorServerTest.Components
{
    public partial class Test
    {
        [Inject] public WeatherForecastService WeatherForecastService { get; set; } = default!;
        [Parameter] public string Text { get; set; } = default!;
        [Parameter] public IEnumerable<string> Values { get; set; }

        public string Item { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Item = await StringReturn();

            return;
        }

        public async Task<string> StringReturn()
        {
            var item = (await  WeatherForecastService.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now))).FirstOrDefault();

            return item.Date + " Method Result";
        }
    }


}
