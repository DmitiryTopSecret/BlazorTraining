using BlazorServerTest.Data.Sources;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerTest.Components
{
    public partial class SourceComponent
    {
        [Inject] public SourceService SourceService { get; set; }
        private const string SourceId = "1";

        [Parameter] public Source OneSource { get; set; } = new Source();

        protected override async Task OnInitializedAsync()
        {
            OneSource = new Source(); /*await GetSource(SourceId);*/

            return;
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }

        //public async Task<Source> GetSource(string id)
        //{
        //    var s = await SourceService.GetSourceByIdAsync(id);

        //    return await Task.FromResult(s);
        //}
    }
}
