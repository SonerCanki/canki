﻿using System;

namespace Canki.Model.Services.EnvironmentService
{
    public class EnvironmentService : IEnvironmentService
    {
        public string EnvironmentName { get; set; }
        public EnvironmentService()
        {
            EnvironmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";
        }
    }
}
