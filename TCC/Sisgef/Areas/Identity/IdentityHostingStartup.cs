using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sisgef.Areas.Identity.Data;
using Sisgef.Data;

[assembly: HostingStartup(typeof(Sisgef.Areas.Identity.IdentityHostingStartup))]
namespace Sisgef.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SisgefContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SisgefContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SisgefContext>();
            });
        }
    }
}