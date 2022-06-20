using BeerAPI.Data;
using BeerAPI.Data.Interfaces;
using BeerAPI.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace BeerAPI
{
    public class Startup
    {
        public Startup(IConfiguration _) => Configuration = _;

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /// Get ConnectionString
            var sqlConnectionConf = new SqlConfiguration(Configuration.GetConnectionString("BeerConnection"));

            // Inject dependencies
            services.AddSingleton<ITradeMarkRepo, TradeMarkRepo>();
            services.AddSingleton<IBeerRepo, BeerRepo>();

            // Add services
            services.AddSingleton(sqlConnectionConf);
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BeerAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BeerAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
