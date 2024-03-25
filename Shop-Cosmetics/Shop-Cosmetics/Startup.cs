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
        public void ConfigureServices(IServiceCollection services){
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            /*app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            */

            int summ = 0;
            string[] words = new string[] {"[ test ]" };
            Random random = new Random();
            int[] num = new int[1000000];

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {

                    await context.Response.WriteAsync("Hello World!\n");
                    for (int i = 0; i < num.Length; i++)
                    {
                        num[i] = random.Next(1, 100);

                        await context.Response.WriteAsync($"[ {num[i]} ]");
                        summ = summ + num[i];

                        switch (num[i])
                        {
                            case 80:
                                await context.Response.WriteAsync(words[0]);
                                break;
                        }
                    }

                    

                    await context.Response.WriteAsync($"\nMin: {num[50]}");
                    await context.Response.WriteAsync($"\nSumma: {summ}");

                });
            });



        }
    }
}