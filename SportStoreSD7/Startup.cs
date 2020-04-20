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
                //Configuration["Data:SportStoreSD7Products:ConnectionString"]
                Configuration["Data:SportStoreSD7Products:ConnectionString4"]       //From Dan VM
                ));                                                                 //Page 212. Also see appsettings.json Line 12.
            //services.AddTransient<IProductRepository, FakeProductRepository>(); //Page 203, 212.  //EFProductRepository>(); pg. 213.
            services.AddTransient<IProductRepository, EFProductRepository>();     //Page217
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));                //Page 273.
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();     //Page 273.
            services.AddTransient<IOrderRepository, EFOrderRepository>();           //Page 287.
            services.AddMvc(options => options.EnableEndpointRouting = false);    //Page 196. Also by Dan.   //Removed from page 263.
            services.AddMemoryCache();                  //Page 263.
            services.AddSession();                     //Page 263.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //----------------------------------------------Comment out Page 217---------------------------242********
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //    app.UseStatusCodePages();
            //}
            //-------------------------------------------------------------------------------
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
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();                                               //Page 264.
            app.UseMvc(routes => 
            {
                //routes.MapRoute(                                          //Comment out Page 242.
                //    name: "pagination",
                //    template: "Products/Page{productPage}",
                //    defaults: new { Controller = "Product", action = "List" });

                //routes.MapRoute(                                          //Comment out Page 242.
                //    name: "default",
                //    template: "{controller=Product}/{action=List}/{id?}");
                routes.MapRoute(
                    name: null,
                    template: "{category}/Page{productPage:int}",
                    defaults: new { controller = "Product", action = "List" }
                );
                routes.MapRoute(
                    name: null,
                    template: "Page{productPage:int}",
                    defaults: new
                    {
                        controller = "Product",
                        action = "List",
                        productPage = 1
                    }
                );
                routes.MapRoute(
                    name: null,
                    template: "{category}",
                    defaults: new
                    {
                        controller = "Product",
                        action = "List",
                        productPage = 1
                    }
                );
                routes.MapRoute(
                    name: null,
                    template: "",
                    defaults: new
                    {
                        controller = "Product",
                        action = "List",
                        productPage = 1
                    }
                );
                routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");
            });
            //SeedData.EnsurePopulated(app);
        }
    }
}
