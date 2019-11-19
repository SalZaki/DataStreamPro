using System.Net.Http;

namespace DataStreamPro.Common.Utils.Extensions
{
    public static class HttpMethodExtensions
    {
        public static bool ShouldHaveRequestBody(this HttpMethod method)
        {
            return method == HttpMethod.Post || method == HttpMethod.Put;
        }
    }
}