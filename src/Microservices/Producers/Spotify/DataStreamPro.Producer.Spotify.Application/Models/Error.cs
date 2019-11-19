using System.Diagnostics.CodeAnalysis;

namespace DataStreamPro.Producer.Spotify.Application.Models
{
    [ExcludeFromCodeCoverage]
    public class Error
    {
        public string Title { get; set; }

        public string Reason { get; set; }

        public int Code { get; set; }

        public string Description { get; set; }

        public string DocumentationUrl { get; set; }
    }
}
