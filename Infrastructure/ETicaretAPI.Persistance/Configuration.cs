using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                //configurationManager.SetBasePath(Path.Combine("D:/SEYIT/C#/ETicaretAPI"));
                configurationManager.SetBasePath(Path.Combine("D:/SEYIT/C#/ETicaretAPI/ETicaretAPI.WebAPI"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("PostgreSQL");
            }
        }
    }
}
