using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RecipePlatform.DAL;
using RecipePlatform.DAL.Repositories;
using RecipePlatform.BLL.Services;

namespace RecipesPlatform.WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Load appsettings.json
            builder.Configuration.AddJsonFile("appsettings.json");

            // Add DbContext
            builder.Services.AddDbContext<RecipeDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Register Repository and Service
            builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
            builder.Services.AddScoped<IRecipeService, RecipeService>();

            // Add HttpClient service
            builder.Services.AddHttpClient();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            builder.Services.AddHttpClient();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            using Microsoft.EntityFrameworkCore;
            using Microsoft.Extensions.Configuration;
            using RecipePlatform.DAL;
            using RecipePlatform.DAL.Repositories;
            using RecipePlatform.BLL.Services;

namespace RecipesPlatform.WEB
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                var builder = WebApplication.CreateBuilder(args);

                // Load appsettings.json
                builder.Configuration.AddJsonFile("appsettings.json");

                // Add DbContext
                builder.Services.AddDbContext<RecipeDbContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

                // Register Repository and Service
                builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
                builder.Services.AddScoped<IRecipeService, RecipeService>();

                // Register HttpClient (for calling APIs)
                builder.Services.AddHttpClient();

                // Add MVC support
                builder.Services.AddControllersWithViews();

                var app = builder.Build();

                // Configure HTTP request pipeline
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
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                app.Run();
            }
        }
    }

    app.Run();
        }
    }
}
