using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domin.Interfaces;
using CleanArch.Infra.Data.Reposietory;
using Microsoft.Extensions.DependencyInjection;

namespace TopDev.Infra.IoC
{
    public class DependencyContanier
    {
        public static void RegisterService(IServiceCollection service)
        {
            service.AddScoped<ICourseService, CourseService>();

            service.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}