using System.Linq;

using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;

using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace DataStreamPro.Producer.Spotify.Host.Extensions
{
    public class SwaggerConfigureOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider provider;

        public SwaggerConfigureOptions(IApiVersionDescriptionProvider provider) => this.provider = provider;

        public void Configure(SwaggerGenOptions options)
        {
            provider.ApiVersionDescriptions.ToList().ForEach(d =>
            {
                options.SwaggerDoc(d.GroupName, CreateInfoForApiVersion(d));
            });
        }

        private static Info CreateInfoForApiVersion(ApiVersionDescription description)
        {
            var info = new Info()
            {
                Title = "Alpha Travel Web API",
                Version = description.ApiVersion.ToString(),
                Description = "This is DataStream Spotify web api v1.0.",
                TermsOfService = "Open Source",
                Contact = new Contact
                {
                    Name = "Sal Zaki",
                    Email = "salzaki@hotmail.com",
                    Url = "https://github.com/salzaki"
                },
                License = new License
                {
                    Name = "MIT",
                    Url = "https://opensource.org/licenses/MIT"
                },
            };

            if (description.IsDeprecated)
            {
                info.Description += " This API version has been deprecated.";
            }

            return info;
        }
    }
}