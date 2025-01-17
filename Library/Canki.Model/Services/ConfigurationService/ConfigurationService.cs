﻿using Canki.Model.Services.EnvironmentService;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Canki.Model.Services.ConfigurationService
{
    public class ConfigurationService : IConfigurationService
    {
        private IEnvironmentService _env { get; }
        public string CurrentDirectory { get; set; }
        public ConfigurationService(IEnvironmentService env)
        {
            _env = env;
        }
        public IConfiguration GetConfiguration()
        {
            CurrentDirectory = CurrentDirectory ?? Directory.GetCurrentDirectory();
            return new ConfigurationBuilder()
                .SetBasePath(CurrentDirectory)
                .AddJsonFile("appsettings.json", reloadOnChange: true, optional: true)
                .AddJsonFile($"appsettings.{_env.EnvironmentName}.json", reloadOnChange: true, optional: true)
                .AddEnvironmentVariables()
                .Build();
        }
    }
}
