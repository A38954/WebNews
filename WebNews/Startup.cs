using Auth0.ManagementApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebNews.Data.EF;
using WebNews.Data.Entities;

namespace WebNews 
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //dang ki dich vu pagerazor
            services.AddRazorPages();

            services.AddDbContext<WebNewsDbContext>(options =>
            {
                string connectionstrings = Configuration.GetConnectionString("WebNewsDb");
                options.UseSqlServer(connectionstrings);
            });
          


        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            //tra ve loi tu loi 404 
            app.UseStatusCodePages();
            app.UseRouting();
            //xac nhan danh tinh -> login logout 
            app.UseAuthentication();
            //xac thuc quyen truy cap
            app.UseAuthorization();
            //xac nhan danh tinh -> login logout 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=CRUDUser}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "My-route",
                    pattern: "route/{controller}/{action}/{id?}"
                    );
                endpoints.MapRazorPages();
            });
        }
    }
}