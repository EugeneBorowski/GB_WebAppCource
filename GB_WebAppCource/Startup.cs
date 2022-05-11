using AutoMapper;
using GB_WebAppCource.Controllers.Models;
using GB_WebAppCource.DAL.Repository;
using GB_WebAppCource.DAL.Repository.Database;
using GB_WebAppCource.DAL.Repository.Interfaces;
using GB_WebAppCource.Mapper;
using GB_WebAppCource.Services;
using GB_WebAppCource.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

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
            string connectionString = "Server=127.0.0.1;Port=5432;Database=Persons;Username=postgres;Password=af30df1a;";

            services.AddDbContext<Context>(options => options.UseNpgsql(connectionString));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GB_WebAppCource", Version = "v1" });
            });

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
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Persons"));
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
