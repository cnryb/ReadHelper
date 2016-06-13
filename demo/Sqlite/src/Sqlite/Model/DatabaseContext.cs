using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sqlite.Model
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }
        public DbSet<T2> T2 { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Startup s = new Startup(HostingEnvironment);

            //IHostingEnvironment env = HtmlHelper.ViewContext.HttpContext.RequestServices.GetService(typeof(IHostingEnvironment)) as IHostingEnvironment;

            //var configuration = new ConfigurationBuilder()
            // .AddJsonFile("appsettings.json");
            //IConfigurationRoot Configuration = configuration.Build();
            //var connection = Configuration["Production:SqliteConnectionString"];
            optionsBuilder.UseSqlite("Data Source=./test.sqlite");
        }
    }
}
