using System;
using asp_taller_pi_1__2_.Areas.Identity.Data;
using asp_taller_pi_1__2_.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(asp_taller_pi_1__2_.Areas.Identity.IdentityHostingStartup))]
namespace asp_taller_pi_1__2_.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public int ID   { get; set; }
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
           
            });
        }
    }
}