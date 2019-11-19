using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DataStreamPro.Common.Utils.Helpers
{
    public class ConfigurationHelper
    {
        public static IConfigurationRoot GetConfiguration(string basePath = null)
        {
            basePath = basePath ?? Directory.GetCurrentDirectory();
            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{ Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true)
                .AddEnvironmentVariables();

            return builder.Build();
        }
    }
}