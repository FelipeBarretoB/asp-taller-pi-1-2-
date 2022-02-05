using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_taller_pi_1__2_.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using asp_taller_pi_1__2_.Areas.Identity;
using asp_taller_pi_1__2_.Areas.Model;

namespace asp_taller_pi_1__2_.Data
{
    public class Db_Context1 : IdentityDbContext<asp_taller_pi_1__2_User>
    {
        public int ID { get; set; }
        public Db_Context1(DbContextOptions<Db_Context1> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<asp_taller_pi_1__2_.Areas.Identity.IdentityHostingStartup> IdentityHostingStartup { get; set; }

        public DbSet<asp_taller_pi_1__2_.Areas.Model.Format> Format { get; set; }
    }
}
