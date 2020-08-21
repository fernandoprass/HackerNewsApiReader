using API.Contracts;
using API.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        /// <summary> Configure services </summary>
        /// <param name="services"></param> 
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            ConfigureDependencyInjection(services);
        }

        /// <summary> The Database connection configuration </summary>
        /// <param name="services"></param>
        private void ConfigureDatabaseConnection(IServiceCollection services)
        {
            throw new NotImplementedException();
        }

        /// <summary> The Dependency Injection configuration </summary>
        /// <param name="services"></param>
        private static void ConfigureDependencyInjection(IServiceCollection services)
        {
            services.AddTransient<IStoryService, StoryService>();
        }

        /// <summary> Configure application </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
