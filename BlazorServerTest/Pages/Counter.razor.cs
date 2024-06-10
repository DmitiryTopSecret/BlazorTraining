using BlazorServerTest.Data;
using BlazorServerTest.Data.Sources;
using Microsoft.AspNetCore.Components;

namespace BlazorServerTest.Pages
{
    public partial class Counter
    {
        [Inject] public WeatherForecastService WeatherForecastService { get; set; } = default!;
        public string TextCounter { get; set; } = default!;
        public IEnumerable<string> ValuesCounter { get; set; }

        protected override void OnInitialized()
        {
            TextCounter = "blabla text";
            ValuesCounter = new List<string>() { "Bool", "Int", "Double"};

            base.OnInitialized();
        }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
