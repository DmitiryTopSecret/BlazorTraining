
namespace BlazorServerTest.Data.Sources
{
    public class Source
    {
        public string Id { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int? UsersCount { get; set; } = 0;
        public DateTime? DataCreatedAt { get; set; }
        public DateTime? DataUpdatedAt { get; set; }
    }
}
