using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SportStoreSD7.Models;                 //Page 203.
using Microsoft.Extensions.Configuration;  //Page 212.
using Microsoft.EntityFrameworkCore;        //Page 212.

namespace SportStoreSD7
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;  //Page 212. New constructor
        public IConfiguration Configuration { get; }    //Page 212. get; means read only.

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(
                Configuration["Data:SportStoreSD7Products:ConnectionString"]
                ));                                                                 //Page 212. Also see appsettings.json.
            services.AddTransient<IProductRepository, FakeProductRepository>(); //Page 203.  //EFProductRepository>(); pg. 213.
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }

            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("SportStoreSD7!");
            //    });
            //});
            //app.UseDeveloperExceptionPage();
            //app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Product}/{action=List}/{id?}");
            });
        }
    }
}
