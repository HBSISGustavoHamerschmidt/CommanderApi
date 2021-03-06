using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Commander.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;

namespace Commander
{
    public class Startup
    {

        // Web Api, says that we have access to the configuration API
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // Add Services that will be used in our application
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CommanderContext>(opt => 
                opt.UseSqlServer(Configuration.GetConnectionString("CommanderConnection")));

            services.AddControllers().AddNewtonsoftJson(s =>
                s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());
            // Whenever our application asks for the interface in the first parameter,
            // give it the second parameter (the Class with functions implemented)
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<ICommanderRepo, SqlCommanderRepo>();
            // services.AddScoped<ICommanderRepo, MockCommanderRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Configure request pipelines.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
