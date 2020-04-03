using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SportStoreSD7
{
    //public class Program                              //Page 214.
    //{
    //    public static void Main(string[] args)
    //    {
    //        CreateHostBuilder(args).Build().Run();
    //    
    public class Program            //Page 214.
    {
        public static void Main(string[] args)      //Page 214.
        {
            //BuildWebHost(args).Run();                     //#2
            //CreateHostBuilder(args).Build().Run();          //#3
            BuildWebHost(args).Run();
        }
        //#4
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .UseDefaultServiceProvider(options =>
            options.ValidateScopes = false)
            .Build();                                      //Page 214. Had to retype and removed }); at the bottom of .Build();
        
        //#3
        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>()
        //            .UseDefaultServiceProvider(options => options.ValidateScopes = false)
        //            .Build();                                         //Can't have 2 .Build on line 24. By Dan.
        //        });

        //#2
        //public static IWebHost BuildWebHost(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>()
        //        .UseDefaultServiceProvider(options =>
        //            options.ValidateScopes = false)
        //        .Build();


        //Host.CreateDefaultBuilder(args)                            //See page 214 for WebHost.
        //    .ConfigureWebHostDefaults(webBuilder =>
        //    {
        //        webBuilder.UseStartup<Startup>();
        //    });
    }
}
