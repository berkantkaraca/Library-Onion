using Library.Application.MappingProfiles;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Application.DependencyResolvers
{
    public static class MapperResolver
    {
        public static void AddMapperService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
