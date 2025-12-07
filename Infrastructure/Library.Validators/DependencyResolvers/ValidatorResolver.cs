using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;


namespace Library.Validators.DependencyResolvers
{
    public static class ValidatorResolver
    {
        public static void AddValidatorServices(this IServiceCollection services)
        {
            // FluentValidation'ın otomatik model doğrulama desteği
            services.AddFluentValidationAutoValidation();

            // Bulunduğu assembly'i tarayarak tüm validator'ları ekler
            services.AddValidatorsFromAssembly(typeof(ValidatorResolver).Assembly);
        }
    }
}
