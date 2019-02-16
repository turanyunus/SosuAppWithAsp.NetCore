using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.IdentityCore
{
    public class DesignTimeIdentityDbContextFactory : IDesignTimeDbContextFactory<ApplicationIdentityDBContext>
    {
        public ApplicationIdentityDBContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json")
           .Build();

                var builder = new DbContextOptionsBuilder<ApplicationIdentityDBContext>();
                var connectionString = configuration.GetConnectionString("IdentityConnection");
                builder.UseSqlServer(connectionString);
                return new ApplicationIdentityDBContext(builder.Options);
        }
    }
}
