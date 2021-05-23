using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.Base;
using Repository;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;
using Service.Services;

namespace Api
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
            // Mapeamento para as interfaces e repositórios
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));

            // Colocar a string de conexão no contexto.
            services.AddDbContext<AppContextApi>(op => op.UseSqlServer(Configuration.GetConnectionString("DataBase")));

            // Mapear as interfaces dos serviços
            services.AddTransient<ISeller, SellerService>();
            services.AddTransient<IClient, ClientService>();


            services.AddControllers();


            services.AddCors(b => b.AddPolicy("MinhaPolitica", builder => {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
                       
            }));
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

            // Implementa as politicas do CORS
            app.UseCors(f => f.AllowAnyOrigin());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
