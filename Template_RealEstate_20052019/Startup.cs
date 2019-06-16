using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;
using Template_RealEstate_20052019.Database;
using Template_RealEstate_20052019.Models;
using Template_RealEstate_20052019.Repositories;
using Template_RealEstate_20052019.Utils;
using IDatabase = Template_RealEstate_20052019.Database.IDatabase;

namespace Template_RealEstate_20052019
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(60);
            });
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.Configure<ProjectInformation>(Configuration.GetSection("ProjectInformartion"));
            services.Configure<Location>(Configuration.GetSection("Location"));
            services.Configure<DbConfig>(Configuration.GetSection("DbConfig"));
            services.Configure<ContactInformation>(Configuration.GetSection("Contact"));
            services.AddSingleton<IDatabase, SqlServerDatabase>();
            services.AddSingleton<IArticleRepository, ArticleRepository>();
            services.AddSingleton<IContactRepository, ContactRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IUtilityRepository, UtilityRepository>();
            services.AddSingleton<IKeyValueRepository, KeyValueRepository>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            var provider = services.BuildServiceProvider();
            var userRepository = provider.GetService<IUserRepository>();
            userRepository.CreateUser(new User
            {
                Username = "admin",
                Password = Crypto.HashPassword("abc@123"),
                UserType = UserEnum.UserType.Admin,
                Email = Configuration.GetSection("Contact:Email").Get<string>()
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{area=FrontEnd}/{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "admin",
                    template: "{area=BackEnd}/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
