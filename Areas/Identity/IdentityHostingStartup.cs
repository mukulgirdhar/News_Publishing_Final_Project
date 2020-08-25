using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using News_Publishing_Final_Project.Models;

[assembly: HostingStartup(typeof(News_Publishing_Final_Project.Areas.Identity.IdentityHostingStartup))]
namespace News_Publishing_Final_Project.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<News_Publishing_IdentityDataContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("News_Publishing_IdentityDataContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<News_Publishing_IdentityDataContext>();
            });
        }
    }
}