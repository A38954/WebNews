using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNews.Data.EF
{
    public class WebNewsDbContextFactory : IDesignTimeDbContextFactory<WebNewsDbContext>
    {
        public WebNewsDbContext CreateDbContext(string[] args)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("WebNewsDb");

            var optionsBuilder = new DbContextOptionsBuilder<WebNewsDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new WebNewsDbContext(optionsBuilder.Options);
        }
    }
}
