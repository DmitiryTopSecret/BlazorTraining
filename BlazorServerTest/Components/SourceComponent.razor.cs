using BlazorServerTest.Data.Sources;
using Microsoft.AspNetCore.Components;
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


        public Source OneSource { get; set; }

        protected override async Task OnInitializedAsync()
        {
            OneSource = await GetSource(SourceId);

            return;
        }

        public async Task<Source> GetSource(string id)
        {
            var s = await SourceService.GetSourceByIdAsync(id);

            return await Task.FromResult(s);
        }
    }
}
