﻿using Microsoft.Extensions.Configuration;
using System;

namespace SharpCounter.Config
{
    public static class AppSecrets
    {
        public static string GetAppSettingsValue(IConfiguration Configuration, string name)
        {
            try
            {
                string value = Configuration.GetSection("AppSettings")[name];
                if (!string.IsNullOrEmpty(value))
                {
                    return value;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Could not find it in the Configuration");
                Console.WriteLine("using the following value instead: " + Environment.GetEnvironmentVariable(name));
            }

            return Environment.GetEnvironmentVariable(name);
        }

        public static string GetConnectionString(IConfiguration Configuration, string name)
        {
            try
            {
                string value = Configuration.GetConnectionString(name);
                if (!string.IsNullOrEmpty(value))
                {
                    return value;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Could not find it in the Configuration");
                Console.WriteLine("using the following value instead: " + Environment.GetEnvironmentVariable(name));
            }

            return Environment.GetEnvironmentVariable(name);
        }
    }
}