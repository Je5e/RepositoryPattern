using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoPatron.DAL
{
   public class Helper
    {
        private readonly string KeyName;
        public Helper(string keyName)
        {
            this.KeyName = keyName;
        }
        // ConfigurationBuilder
        public string GetConnectionString()
        {
            var Configuration = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return Configuration.GetConnectionString(KeyName);
        }
    }
}
