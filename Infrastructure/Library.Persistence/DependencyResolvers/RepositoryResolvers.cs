using Library.Contract.RepositoryInterfaces;
using Library.Persistence.RepositoryConcretes;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Persistence.DependencyResolvers
{
    public static class RepositoryResolvers
    {
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookTagRepository, BookTagRepository>();
            services.AddScoped<ITagRepository, TagRepository>();

            //BaseRepository abstract değilse ve generic ise aşağıdaki satır kullanılabilir.
            //services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
        }
    }
}
