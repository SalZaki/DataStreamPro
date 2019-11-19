﻿using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

using Microsoft.Extensions.Configuration;

namespace DataStreamPro.Common.Utils.Extensions
{
    public static class ConfigurationExtensions
    {
        public static IEnumerable<Assembly> LoadFullAssemblies(this IConfiguration config)
        {
            if (string.IsNullOrEmpty(config.GetValue<string>("QualifiedAssemblyPattern")))
                throw new Exception(
                    "Add QualifiedAssemblyPattern key in appsettings.json for automatically loading assembly.");

            return config.GetValue<string>("QualifiedAssemblyPattern").LoadFullAssemblies();
        }

        public static IEnumerable<Assembly> LoadApplicationAssemblies(this IConfiguration config)
        {
            if (string.IsNullOrEmpty(config.GetValue<string>("QualifiedAssemblyPattern")))
                throw new Exception(
                    "Add QualifiedAssemblyPattern key in appsettings.json for automatically loading assembly.");

            var apps = config.GetValue<string>("QualifiedAssemblyPattern").LoadAssemblyWithPattern();
            if (apps == null || !apps.Any())
                throw new Exception("Should have at least one application assembly to load.");

            return apps;
        }
    }
}
