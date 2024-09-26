using HealthcareHospitalManagementSystem.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HealthcareHospitalManagementSystem
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Register controllers with JSON options
            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
                options.JsonSerializerOptions.DictionaryKeyPolicy = null;
            });
            
            // Register Swagger for API documentation
            services.AddSwaggerGen();

            // Register DoctorService as Singleton for in-memory data persistence
            services.AddSingleton<IDoctorService, DoctorService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Use developer exception page during development
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHttpsRedirection();
            }

            // Enable Swagger for API documentation
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Hospital API v1"));

            // Enable routing
            app.UseRouting();

            // Map endpoints to controllers
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}