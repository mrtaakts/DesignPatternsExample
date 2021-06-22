using BaseProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var host = CreateHostBuilder(args).Build();


            using var scope = host.Services.CreateScope();


            var identityDbContext = scope.ServiceProvider.GetRequiredService<AppIdentityDbContext>();


            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

            identityDbContext.Database.Migrate();


            if(!userManager.Users.Any())
            {
                userManager.CreateAsync(new AppUser() { UserName = "darkcack", Email = "darkcack@gmail.com" }, "Password12.").Wait();
                userManager.CreateAsync(new AppUser() { UserName = "darkcack2", Email = "darkcack2@gmail.com" }, "Password12.").Wait();
                userManager.CreateAsync(new AppUser() { UserName = "darkcack3", Email = "darkcack3@gmail.com" }, "Password12.").Wait();
                userManager.CreateAsync(new AppUser() { UserName = "darkcack4", Email = "darkcack4@gmail.com" }, "Password12.").Wait();
                userManager.CreateAsync(new AppUser() { UserName = "darkcack5", Email = "darkcack5@gmail.com" }, "Password12.").Wait();
            }


            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
