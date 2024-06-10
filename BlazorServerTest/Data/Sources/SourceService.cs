using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerTest.Data.Sources
{
    public class SourceService
    {
        private readonly List<Source> Sources = new List<Source>()
        {
            new Source
            {
                Id = "1",
                Url = "some/url",
                Name = "Source one",
                Title = "Title",
                Description = "Description",
                UsersCount = 1,
                DataCreatedAt= DateTime.Now,
                DataUpdatedAt= DateTime.Now.AddMinutes(4)
            },
            new Source
            {
                Id = "2",
                Url = "some/url",
                Name = "Source two",
                Title = "Title",
                Description = "Description",
                UsersCount = 2,
                DataCreatedAt= DateTime.Now,
                DataUpdatedAt= DateTime.Now.AddMinutes(3)
            },
            new Source
            {
                Id = "3",
                Url = "some/url",
                Name = "Source three",
                Title = "Title",
                Description = "Description",
                UsersCount = 3,
                DataCreatedAt= DateTime.Now,
                DataUpdatedAt= DateTime.Now.AddMinutes(2)
            }
        };

        public async Task<IEnumerable<Source>> GetAllSourcesAsync()
        {
            return await Task.FromResult(Sources);
        }

        public async Task<Source> GetSourceByIdAsync(string sourceId)
        {
            return await Task.FromResult(Sources.FirstOrDefault(x => x.Id == sourceId));
        }
    }
}
