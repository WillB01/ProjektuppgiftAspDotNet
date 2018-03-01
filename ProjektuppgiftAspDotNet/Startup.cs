using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjektuppgiftAspDotNet.Data;
using ProjektuppgiftAspDotNet.Interface;
using ProjektuppgiftAspDotNet.Models;

namespace ProjektuppgiftAspDotNet
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration) =>
            Configuration = configuration;
       
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IUserRepository, UserRepository>();




            //testing

            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("LogInConnection")));

            services.AddIdentity<AppUser, IdentityRole>(options =>
             {
                 options.Password.RequiredLength = 6;
                 options.Password.RequireNonAlphanumeric = false;
                 options.Password.RequireLowercase = false;
                 options.Password.RequireUppercase = false;
                 options.Password.RequireDigit = false;
             }).AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();







            services.AddMvc();
        }

       
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseMvc(routes =>
                routes.MapRoute(
                    name: "default",
                    template: "{Controller=Home}/{action=Index}/{id?}"
            ));


           
        }
    }
}
