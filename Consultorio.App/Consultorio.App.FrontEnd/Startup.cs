using System.Net.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Consultorio.App.Persistencia;


namespace Consultorio.App.FrontEnd
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
            //services.AddRazorPages();

            services.AddRazorPages(
                options => {
                    options.Conventions.AuthorizePage("/Index");
                    options.Conventions.AuthorizeFolder("/Saludos");

                    options.Conventions.AllowAnonymousToPage("/Privacy");
                }
            );


            AppContexto _contexto = new AppContexto();
            services.AddSingleton<IRepositorioCliente>(new RepositorioCliente(_contexto));
            services.AddSingleton<IRepositorioMedico>(new RepositorioMedico(_contexto));
            services.AddSingleton<IRepositorioAuxiliar>(new RepositorioAuxiliar(_contexto));
            services.AddSingleton<IRepositorioCita>(new RepositorioCita(_contexto));
            services.AddSingleton<IRepositorioHorario>(new RepositorioHorario(_contexto));

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }

    }
}
