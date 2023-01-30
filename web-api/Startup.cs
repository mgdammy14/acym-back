using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBusinessLogic.Implementation.General;
using ApiBusinessLogic.Implementation.Member;
using ApiBusinessLogic.Implementation.User;
using ApiBusinessLogic.Interfaces.General;
using ApiBusinessLogic.Interfaces.Member;
using ApiBusinessLogic.Interfaces.User;
using ApiDataAccess.General;
using ApiUnitOfWork.General;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace web_api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddScoped<IUserLogic, UserLogic>();
            services.AddScoped<IMemberLogic, MemberLogic>();
            services.AddScoped<ILoginLogic, LoginLogic>();

            services.AddSingleton<IUnitOfWork>(option => new UnitOfWork(
                    Configuration.GetConnectionString("develop-azure")
                ));

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Back-End Acym Juanjui", Version = "v1" });
                
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x => x
               .AllowAnyMethod()
               .AllowAnyHeader()
               .SetIsOriginAllowed(origin => true) // allow any origin
               .AllowCredentials()); // a
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Back-End Acym Juanjui"));
        }
    }
}
