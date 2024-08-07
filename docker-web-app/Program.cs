using Docker_compose_web_app.Data;
using Microsoft.EntityFrameworkCore;

namespace Docker_compose_web_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Database conection string creation, will be used as env variables in the container

            var dbHost = Environment.GetEnvironmentVariable("DB_HOST") ?? "localhost";
            var dbName = Environment.GetEnvironmentVariable("DB_NAME") ?? "DockerSQLDatabase";
            var dbUser = Environment.GetEnvironmentVariable("DB_USER_ID") ?? "SA";
            var dbPassword = Environment.GetEnvironmentVariable("DB_SA_PASSWORD") ?? "badfather2024@@";
            var DockerSQLConnection = $"Data Source = {dbHost}; Initial Catalog = {dbName};User ID = {dbUser}; Password = {dbPassword}; TrustServerCertificate = True;Encrypt=false;MultiSubnetFailover=True;";

            builder.Services.AddDbContext<MovieContext>(
               options => options.UseSqlServer(DockerSQLConnection));

            var app = builder.Build();            


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
