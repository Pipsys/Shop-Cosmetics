using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Shop_Cosmetics
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Random random = new Random();
            double[] array = new double[100];
            double summa = 0;

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            if (env.IsProduction())
            {     

            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    
                    await context.Response.WriteAsync("Hello World!\n");
                    for(int i = 0; i < array.Length; i++)
                    {
                        array[i] = random.Next(1, 100);

                        await context.Response.WriteAsync($"[ {array[i]} ]");
                        summa = summa + array[i];
                    }

                    
                    await context.Response.WriteAsync($"\nSumma: {summa}");
                    
                });
            });
        }
    }
}

