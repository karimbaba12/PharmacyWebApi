using UMS_BLL.Services.Auth;
using UMS_BLL.Services.Faculties;
using UMS_BLL.Services.Majors;
using UMS_BLL.Services.Users;

namespace UMS_WebAPI_New.Extentions
{
    public static class ServiceExtention
    {

        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddScoped<IFacultyService, FacultyService>();
            services.AddScoped<IMajorService, MajorService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>(); 
            return services;
        }
    }
}
