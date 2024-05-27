using UMS_DAL.Repositories.Faculties;
using UMS_DAL.Repositories.Majors;
using UMS_DAL.Repositories.Users;

namespace UMS_WebAPI_New.Extentions
{
    public static class RepositoryExtention
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {

            services.AddScoped<IFacultyRepository, FacultyRepository>();
            services.AddScoped<IMajorRepository, MajorRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
          
            return services;
        }

    }
}
