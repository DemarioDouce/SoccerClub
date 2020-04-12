using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demario_D_301021637.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Demario_D_301021637.Infrastructure;

namespace Demario_D_301021637
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
            Configuration["Data:SoccerClubClubs:ConnectionString"]));
            services.AddDbContext<AppIdentityDbContext>(options =>
            options.UseSqlServer(
            Configuration["Data:SoccerClubIdentity:ConnectionString"]));
            services.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<AppIdentityDbContext>()
            .AddDefaultTokenProviders();
            services.AddTransient<IClubsRepository, EFClubsRepository>();
            services.AddTransient<IPlayersRepository, EFPlayersRepository>();

            services.AddSingleton<UptimeService>();
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseDeveloperExceptionPage();
            app.UseBrowserLink();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes => {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
            });
            SeedDataClubs.EnsurePopulated(app);
            SeedDataPlayers.EnsurePopulated(app);
            IdentitySeedData.EnsurePopulated(app);

        }
    }
}
