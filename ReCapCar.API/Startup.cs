using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ReCapCar.Business.Abstract;
using ReCapCar.Business.Concreate;
using ReCapCar.DataAccess.Abstract;
using ReCapCar.DataAccess.Concreate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReCapCar.API
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<ICustomerService, CustomerManager>();
            services.AddSingleton<IBrandService, BrandManager>();
            services.AddSingleton<IColorService, ColorManager>();
            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<ICarService, CarManager>(); 
            services.AddSingleton<IRentalService, RentalManager>();

            services.AddSingleton<ICustomerDal, EfCustomerDal>();
            services.AddSingleton<IBrandDal, EfBrandDal>();
            services.AddSingleton<IColorDal, EfColorDal>();
            services.AddSingleton<IUserDal, EfUserDal>();
            services.AddSingleton<ICarDal, EfCarDal>();
            services.AddSingleton<IRentalDal, EfRentalDal>();

            services.AddSwaggerDocument();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors(MyAllowSpecificOrigins);
            app.UseRouting();
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
