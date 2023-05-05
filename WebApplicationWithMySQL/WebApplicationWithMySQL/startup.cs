using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;



//using WebApplicationWithMySQL.Data.MySqlClient;

namespace WebApplicationWithMySQL

{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        //This method gets called by runtime use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            //Enable CORS
            services.AddCors(c=>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

            //JSON Serializer
            services.AddControllersWithViews().AddNewtonsoftJson(options=>
            options.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore)
                .AddNewtonsoftJson(options=>options.SerializerSettings.ContractResolver
                = new DefaultContractResolver());

            // Configure MySQL database connection
            //string connectionString = Configuration.GetConnectionString("MySqlConnection");
            //services.AddTransient<MySqlConnection>(_ => new MySqlConnection(connectionString));

            // Add MVC services
            services.AddControllersWithViews();
        }
        //this method gets called by runtime use this method to configure http requests
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Enable CORS
            app.UseCors( options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           /* else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }*/

           // app.UseHttpsRedirection();
           // app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                  //  name: "default",
                  //  pattern: "{controller}/{action}/{id?}");
            });
        }
    }
}
