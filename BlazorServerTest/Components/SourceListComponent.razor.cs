using BlazorServerTest.Data.Sources;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerTest.Components
{
    public partial class SourceListComponent
    {
        [Inject] public SourceService SourceService { get; set; }

        public IEnumerable<Source> AllSources { get; set; }

        protected override async Task OnInitializedAsync()
        {
            AllSources = await GetAllSources();

            return;
        }

        public async Task<IEnumerable<Source>> GetAllSources()
        {
            var r = await SourceService.GetAllSourcesAsync();

            return await Task.FromResult(r);
        }
    }
}
