using System;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Snowdeed.Kivo.API
{
    using Snowdeed.Kivo.Core;
    using Snowdeed.Kivo.Data.Musics;

    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddCors();

            services.AddOpenApiDocument();

            this.ConfigureDependencyInjection(services);
        }

        private void ConfigureDependencyInjection(IServiceCollection services)
        {

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors(c =>
                {
                    c.AllowAnyHeader();
                    c.AllowAnyMethod();
                    c.AllowAnyOrigin();
                });
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            using (KivoDbContext context = new KivoDbContext(Configuration.GetConnectionString("DefaultConnection")))
            {
                context.CreateDatabase();
                context.CreateTable();

                if (env.IsDevelopment())
                {
                    context.Artist.Add(new Artist() { ID = Guid.NewGuid(), Active = true, Artist_StageName = "The Weeknd", Artist_LastName = string.Empty, Artist_FirstName = string.Empty, Artist_Birthday = new DateTime(1990, 02, 16), Artist_BirthdayPlace = "Toronto, Ontario (Canada)", Artist_IsMan = true});
                }
            }
        }
    }
}