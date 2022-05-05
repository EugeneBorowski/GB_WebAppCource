using AutoMapper;
using GB_WebAppCource.Controllers.Models;
using GB_WebAppCource.DAL.Repository;
using GB_WebAppCource.DAL.Repository.Interfaces;
using GB_WebAppCource.Mapper;
using GB_WebAppCource.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;

namespace GB_WebAppCource
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
            var mapper = new MapperConfiguration(mapper =>
                    mapper.AddProfile(new MapperProfile()))
                .CreateMapper();
            services.AddSingleton(mapper);
            services.TryAddTransient<IPersonsRepository, PersonsRepository>();

            services.TryAddTransient<IService<PersonDto>, PersonsService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
