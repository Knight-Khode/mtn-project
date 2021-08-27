using Church_Web.Configurations;
using Church_Web.Db_Model;
using Church_Web.Implementation.Configurations;
using Church_Web.Interfaces.Repositories;
using Church_Web.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Church_Web
{
    public static class ServiceExtension
    {
        public static void ConfigureDependencyInjection(this IServiceCollection services)
        {
            try
            {
                services.AddIdentity<User, IdentityRole>()
                .AddDefaultTokenProviders()
               .AddEntityFrameworkStores<AppDbContext>()
               .AddDefaultTokenProviders();
                
                services.AddAutoMapper(typeof(MapperInitializer));
                services.AddTransient<IUnitOfWork, UnitOfWork>();
                services.AddTransient<Logger>();
                services.Configure<DataProtectionTokenProviderOptions>(options =>
                {
                    options.TokenLifespan = TimeSpan.FromHours(3);
                });

                services.AddAuthorization(config =>
                {
                    var defaultBuider = new AuthorizationPolicyBuilder();
                    var defaultAuthPolicy = defaultBuider
                    .RequireAuthenticatedUser()
                    .Build();
                    config.DefaultPolicy = defaultAuthPolicy;
                });
                services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/Login");

            }
            catch (Exception)
            {
                //ignore
            }
        }
    }
}
