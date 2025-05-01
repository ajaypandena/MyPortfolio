//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;

namespace AjayPandenaPortfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Get PORT from environment (Render or dev fallback)
            var port = Environment.GetEnvironmentVariable("PORT") ?? "5194";
            var sslPort = "7098";

            app.Urls.Add($"http://*:{port}");
            app.Urls.Add($"https://*:{sslPort}");

            // Auto-open browser when running locally
            if (app.Environment.IsDevelopment())
            {
                try
                {
                    var launchUrl = $"http://localhost:{port}";
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = launchUrl,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Browser launch failed: {ex.Message}");
                }
            }

            // Middleware
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=AjayPandenaPortfolio}/{action=Index}/{id?}");

            app.Run();
        }
    }
}















//namespace AjayPandenaPortfolio
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);

//            // Add services to the container.
//            builder.Services.AddControllersWithViews();

//            var app = builder.Build();

//            // Configure the HTTP request pipeline.
//            if (!app.Environment.IsDevelopment())
//            {
//                app.UseExceptionHandler("/Home/Error");
//                app.UseHsts();
//            }

//            app.UseHttpsRedirection();
//            app.UseStaticFiles();

//            app.UseRouting();

//            app.UseAuthorization();

//            app.MapControllerRoute(
//                name: "default",
//                pattern: "{controller=AjayPandenaPortfolio}/{action=Index}/{id?}");

//            app.Run();
//        }
//    }
//}
