using Microsoft.Extensions.Configuration;
using System;

namespace SharedPackage
{
    public static class Configuration
    {
        public static IConfiguration Config { get; set; }
    }
}
