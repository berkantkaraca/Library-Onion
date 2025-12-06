using Library.Application.Mediator.Handlers.Read.AuthorHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Application.DependencyResolvers
{
    public static class HandlerResolver
    {
        public static void AddHandlerService(this IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(GetAuthorByIdQueryHandler).Assembly));
        }
    }
}
