using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RMalanco.Projects.Data;
using RMalanco.Projects.Interfaces.Base;
using RMalanco.Projects.Service.Base;

namespace RMalanco.Projects.Service.Settings
{
    public static class AppSettings
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings:DefaultConnection"];
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }

        public static IServiceCollection AddSessions(this IServiceCollection services)
        {
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddMvc();
            return services;
        }

        //authentication settings
        public static IServiceCollection AddAuthenticationSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Authentication/Login/Index";
                    options.LogoutPath = "/Authentication/Login/Logout";
                    options.AccessDeniedPath = "/Admin/Error/AccessDenied";
                    //options.Cookie.Name = "RMalanco.Projects";
                    //options.Cookie.HttpOnly = true;
                    //options.Cookie.IsEssential = true;
                    //options.Cookie.SameSite = SameSiteMode.Strict;
                    //options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                    //options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                });
            return services;
        }

    }
}
