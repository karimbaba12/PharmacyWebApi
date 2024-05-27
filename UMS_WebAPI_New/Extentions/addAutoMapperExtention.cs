using UMS_BLL.Mapping;

namespace UMS_WebAPI_New.Extentions
{
    public static class addAutoMapperExtention
    {
        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection service ) 
        {
            service.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            }, typeof(Program));
            return service;
        }

    }
    
}
