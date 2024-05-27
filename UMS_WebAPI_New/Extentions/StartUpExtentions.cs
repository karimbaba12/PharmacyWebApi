using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using UMS_DAL.Models;

namespace UMS_WebAPI_New.Extentions
{
    public static class StartUpExtentions
    {
    public static IServiceCollection addDb(this IServiceCollection service, ConfigurationManager config)
        {

            var ConnectionString = config.GetConnectionString("DefaultConnection");

            service.AddDbContext<UmsContext>(options => options.UseSqlServer(ConnectionString));
            return service;
        }
       
       
       
    }

}
