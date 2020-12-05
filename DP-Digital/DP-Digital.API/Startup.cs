using DP_Digital.Domain.Candidatos;
using DP_Digital.Domain.Candidatos.Handlers;
using DP_Digital.Domain.Candidatos.Interfaces;
using DP_Digital.Infra.Candidatos.Contexts;
using DP_Digital.Infra.Candidatos.Repositorys;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DP_Digital.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<Settings>(options => Configuration.GetSection("Settings").Bind(options));

            services.AddScoped<MongoDBContext>();

            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DP-DIGITAL API", Version = "v1" });
            });
            #endregion

            #region Handlers
            services.AddScoped<ICandidatoHandler, CandidatoHandler>();
            services.AddScoped<ICandidatoRepository, CandidatoRepository>();
            #endregion

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "DP-DIGITAL API");
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
