using Library.Application.DependencyResolvers;
using Library.Persistence.DependencyResolvers;
using Library.Validators.DependencyResolvers;

namespace Library.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddHandlerService();
            builder.Services.AddMapperService();
            builder.Services.AddDbContextServices();
            builder.Services.AddRepositoryServices();
            builder.Services.AddValidatorServices();

            builder.Services.AddCors();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.MapControllers();

            app.Run();
        }
    }
}
