using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PokemonWebapp.Models;
using PokemonWebapp.ViewModels.HuntViewModel;
using PokemonWebapp.Entities;
using Microsoft.EntityFrameworkCore;
using PokemonWebapp.Repositories;

namespace PokemonWebapp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<HuntViewModel>();
            services.AddDbContext<FightContext>(options => options.UseNpgsql(@"User ID=bblhesokmwuyal;Password=d577608550000222f6f8124d747c7d3fd581404787ce5a98aeb56682a031de69;Host=ec2-54-247-124-9.eu-west-1.compute.amazonaws.com;Port=5432;Database=dcr8rcfi3qjkr4;Pooling=true;sslmode=Require;Trust Server Certificate=true;Timeout=1000;"));
            services.AddScoped<FightRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseStaticFiles();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
