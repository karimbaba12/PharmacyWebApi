using UMS_WebAPI_New.Filters;

namespace UMS_WebAPI_New.Extentions
{
    public static class GlobalException
    {

        public static IServiceCollection GlobalExceptions(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                options.Filters.Add(new GlobalExceptionFilter());
            });
            return services;
        }
    }
}
