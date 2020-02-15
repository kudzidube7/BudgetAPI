using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Logging;
using BudgetingAPI.Models;
using BudgetingAPI.Database;
using Microsoft.EntityFrameworkCore;
using BudgetingAPI.Repositories;
using BudgetingAPI.DataTransferObjects;
using BudgetingAPI.Repositories.Implementations;
using AutoMapper;


namespace BudgetingAPI
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
     
            //services.AddDbContext<BudgetDbContext>(options =>
            //   options.UseSqlServer(
            //   Configuration.GetConnectionString("BudgetingDb"), b => b.MigrationsAssembly("BudgetingAPI")));
            services.AddSwaggerGen(c =>
           {
               c.SwaggerDoc(name: "v1", new OpenApiInfo { Title = "Budgeting Api", Version = "v1" });
               c.CustomSchemaIds(x => x.FullName);
           });

            services.AddDbContext<BudgetDbContext>(options => options.
            UseSqlServer(Configuration["Data:BudgetingDb:ConnectionString"]));

            services.AddTransient<IAccountRepository, AccountRepository>();

            services.AddTransient<ITransactionRepository, TransactionRepository>();

            services.AddAutoMapper(typeof(Startup));

            // services.AddTransient<IAccountRepository, AccountRepository>()


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "BudgetApp"));

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
