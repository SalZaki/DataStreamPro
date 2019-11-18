using System.Diagnostics.CodeAnalysis;

namespace DataStreamPro.Producer.Spotify.Infrastructure.Schema
{
    [ExcludeFromCodeCoverage]
    public class Error
    {
        public int Status { get; set; }
 
        public string mMssage { get; set; }
    }
}