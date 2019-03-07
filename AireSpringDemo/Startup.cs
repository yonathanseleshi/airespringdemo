using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AireSpringDemo.DAOs;
using AireSpringDemo.Repositories;
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AireSpringDemo
{
    public class Startup
    {
        
        readonly string OpenCorsPolicy = "corsPolicy";
        
        
        //The GetDBConnectionString method establishes the AWS System Manager Client
        //The SSM Client is used to retrieve the Postgres RDS connection string from the SSM Parameter Store
        public static string GetDBConnectionString()
        {
 
    


            // Using UsWest2
            var ssmClient = new AmazonSimpleSystemsManagementClient(Amazon.RegionEndpoint.USWest2);

        
            var response = ssmClient.GetParameterAsync(new GetParameterRequest
            {
                Name = "airespringendpoint",
                WithDecryption = true
            });

            return response.Result.Parameter.Value;
        }
        
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
      
            //Establish the CORS Policy
            services.AddCors(options =>
            {
                options.AddPolicy(OpenCorsPolicy,
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
            
            
            //Setting up the Postgresql Database connection
        
            services.AddDbContext<EmployeeDbContext>(options =>
                options.UseNpgsql(GetDBConnectionString()));



            services.AddScoped<IEmployeesRepo, EmployeesRepoImpl>();

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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors(OpenCorsPolicy); 
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();
        }
    }
}